using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class SQLReportRepository : IReportRepository
    {
        private readonly string connectionString;
        IServerHelper helper = new SQLHelper();
        public SQLReportRepository()
        {
            connectionString = helper.GetConnectionString();
        }
        public List<TransactionItem> GetSalesByProduct(DateTime? startDate = null, DateTime? endDate = null)
        {
            var sales = new List<TransactionItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Base query: sum quantity and subtotal grouped by product
                string query = @"
                SELECT 
                    ProductName, 
                    Barcode, 
                    SUM(Quantity) AS TotalQuantity, 
                    SUM(Subtotal) AS TotalSales
                FROM TransactionItems
                /**WHERE_DATE**/
                GROUP BY ProductName, Barcode
                ORDER BY TotalSales DESC";

                string whereClause = "";
                if (startDate.HasValue && endDate.HasValue)
                {
                    whereClause = "WHERE TransactionID IN (SELECT TransactionID FROM Transactions WHERE TransactionDate >= @StartDate AND TransactionDate <= @EndDate)";
                }

                query = query.Replace("/**WHERE_DATE**/", whereClause);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date.AddDays(1).AddSeconds(-1)); // include full day
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Add(new TransactionItem(
                                transactionItemID: 0,
                                transactionID: 0,
                                productID: 0,
                                unitPrice: 0,
                                quantity: Convert.ToInt32(reader["TotalQuantity"]),
                                subTotal: Convert.ToDecimal(reader["TotalSales"]),
                                barcode: reader["Barcode"].ToString(),
                                productName: reader["ProductName"].ToString()
                            ));
                        }
                    }
                }
            }

            return sales;
        }
    }
}
