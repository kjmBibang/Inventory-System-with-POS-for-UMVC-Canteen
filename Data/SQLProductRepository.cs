using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;    
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class SQLProductRepository : IProductRepository
    {
        IServerHelper serverHelper = new SQLHelper();

        public Product GetProduct(string id)
        {
            return null;
        }
        public void UpdateStock(string id)
        {

        }
        public void ReduceStock(string barcode)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
        UPDATE Products
        SET Stock = Stock - 1
        WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Product LoadProductByBarcode(string barcode)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            SELECT Barcode, ProductName, Price, Stock
            FROM Products
            WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new Product(0, reader["Barcode"].ToString(), reader["ProductName"].ToString(), 0, Convert.ToDecimal(reader["Price"]), 0, Convert.ToInt32(reader["Stock"]));
                        
                    }
                }
            }
        }

    }
}
