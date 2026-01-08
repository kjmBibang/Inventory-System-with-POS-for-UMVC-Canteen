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
        // ================= DATA LAYER =================
        public List<Product> SearchProductsByName(string keyword)
        {
            var products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            SELECT TOP 10 *
            FROM Products
            WHERE productName LIKE @keyword
              AND stock > 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product(
                        reader["Barcode"].ToString(),
                        reader["productName"].ToString(),
                        Convert.ToDecimal(reader["Price"]),
                        Convert.ToInt32(reader["stock"])
                    ));
                }
            }

            return products;
        }

        public Product GetProduct(string id)
        {
            return null;
        }
        public void UpdateStock(string id)
        {

        }
        public void ReduceStock(string barcode, int quantity)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
UPDATE Products
SET Stock = Stock - @Quantity
WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AddStock(string barcode, int quantity)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
UPDATE Products
SET Stock = Stock + @Quantity
WHERE Barcode = @Barcode";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
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
                        if (reader.Read())
                        {
                            return new Product(
                                reader["Barcode"].ToString(),
                                reader["ProductName"].ToString(),
                                Convert.ToDecimal(reader["Price"]),
                                Convert.ToInt32(reader["Stock"])
);
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
            }
        }
    }
}