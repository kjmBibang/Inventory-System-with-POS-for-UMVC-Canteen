using Inventory_System_with_POS_for_UMVC_Canteen.Helpers;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class SQLStockRepository : IStockRepository
    {
        IServerHelper serverHelper = new SQLHelper();
        public void AddStockMovement(StockMovement movement)
        {
            using (SqlConnection conn = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            INSERT INTO StockMovement
            (ProductID, StockMovementTypeID, QuantityChange, Reason, CreatedAt, CreatedBy, SupplierID)
            VALUES
            (@ProductID, @MovementType, @QuantityChange, @Reason, @CreatedAt, @CreatedBy, @SupplierID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", movement.productID);
                cmd.Parameters.AddWithValue("@MovementType", (int)movement.movementType);
                cmd.Parameters.AddWithValue("@QuantityChange", movement.quantityChange);
                cmd.Parameters.AddWithValue("@Reason", movement.reason ?? (object)DBNull.Value);
                cmd.Parameters.Add("@CreatedAt", SqlDbType.DateTime)
   .Value = movement.createdAt;

                cmd.Parameters.AddWithValue("@CreatedBy", movement.createdBy);
                cmd.Parameters.AddWithValue("@SupplierID", (object)movement.supplierID ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }
        public void AddStockByProductId(int productId, int quantity)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            UPDATE Products
            SET Stock = Stock + @Quantity
            WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<StockMovement> GetAllStockMovements()
        {
            var list = new List<StockMovement>();

            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            SELECT sm.StockMovementID, sm.ProductID, p.ProductName, sm.QuantityChange, 
                   sm.StockMovementTypeID, sm.SupplierID, s.Name, sm.Reason, sm.CreatedAt, sm.CreatedBy
            FROM StockMovement sm
            LEFT JOIN Products p ON sm.ProductID = p.ProductID
            LEFT JOIN Supplier s ON sm.SupplierID = s.SupplierID
            ORDER BY sm.CreatedAt DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new StockMovement
                            {
                                stockMovementID = Convert.ToInt32(reader["StockMovementID"]),
                                productID = Convert.ToInt32(reader["ProductID"]),
                                productName = reader["ProductName"].ToString(),
                                quantityChange = Convert.ToInt32(reader["QuantityChange"]),
                                movementType = (StockMovementType)Convert.ToInt32(reader["StockMovementTypeID"]),
                                supplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0,
                                supplierName = reader["Name"]?.ToString(),
                                reason = reader["Reason"].ToString(),
                                createdAt = Convert.ToDateTime(reader["CreatedAt"]),
                                createdBy = reader["CreatedBy"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
