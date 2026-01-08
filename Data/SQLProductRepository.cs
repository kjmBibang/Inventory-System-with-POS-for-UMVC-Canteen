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
                    products.Add(new Product
                    {
                        productBarcode = reader["Barcode"].ToString(),
                        productName = reader["productName"].ToString(),
                        unitPrice = Convert.ToDecimal(reader["Price"]),
                        stock = Convert.ToInt32(reader["stock"])
                    });
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
        //====================this should be on stock repo===================
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
        //=============================^^^^^^^^^^^^^^^^ that should be in stock repo========================

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
                            return new Product
                            {
                                productBarcode = reader["Barcode"].ToString(),
                                productName = reader["ProductName"].ToString(),
                                unitPrice = Convert.ToDecimal(reader["Price"]),
                                stock = Convert.ToInt32(reader["Stock"])
                            };
                        }
                        else
                        {
                            return null;
                        }

                    }
                }
            }
        }
        public List<Product> GetAllProductsWithCategory()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                con.Open();

                string query = @"
        SELECT p.ProductID, p.ProductName, p.Barcode,
               p.Price, p.CostPrice, p.Stock,
               c.CategoryName
        FROM Products p
        INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        products.Add(new Product
                        {
                            productBarcode = reader["Barcode"].ToString(),
                            productName = reader["ProductName"].ToString(),
                            unitPrice = (decimal)reader["Price"],
                            stock = (int)reader["Stock"],
                            productID = (int)reader["ProductID"],
                            unitCost = (decimal)reader["CostPrice"],
                            categoryName = reader["CategoryName"].ToString()
                        });
                    }
                }
            }
            return products;
        }
        public List<Product> GetCriticalStockProducts(int threshold)
        {
            var list = new List<Product>();

            using (SqlConnection conn = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            SELECT ProductName, Stock
            FROM Products
            WHERE Stock < @Threshold
            ORDER BY Stock ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Threshold", threshold);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Product
                            {
                                productBarcode = "barcode",
                                productName = reader["ProductName"].ToString(),
                                unitPrice = 0,
                                stock = Convert.ToInt32(reader["Stock"])
                            });

                        }
                    }
                }
            }

            return list;
        }
        public int GetOrCreateCategory(string categoryName)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                con.Open();

                string trimmedName = categoryName.Trim();

                // 1. Check if category exists (case-insensitive)
                string selectQuery = @"
            SELECT CategoryID
            FROM Categories
            WHERE LOWER(LTRIM(RTRIM(CategoryName))) = LOWER(@Name)";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                {
                    selectCmd.Parameters.AddWithValue("@Name", trimmedName);
                    object result = selectCmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result); // existing category
                    }
                }

                // 2. Insert new category if not exists
                string insertQuery = @"
            INSERT INTO Categories (CategoryName)
            VALUES (@Name);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@Name", trimmedName);
                    int newId = (int)insertCmd.ExecuteScalar();
                    return newId;
                }
            }
        }
        public void AddProduct(Product product)
        {
            string query = @"
        INSERT INTO Products
        (ProductName, Barcode, Price, CostPrice, Stock, CategoryID)
        VALUES
        (@ProductName, @Barcode, @Price, @CostPrice, @Stock, @CategoryID)";

            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductName", product.productName);
                cmd.Parameters.AddWithValue("@Barcode", product.productBarcode);
                cmd.Parameters.AddWithValue("@Price", product.unitPrice);
                cmd.Parameters.AddWithValue("@CostPrice", product.unitCost);
                cmd.Parameters.AddWithValue("@Stock", product.stock);
                cmd.Parameters.AddWithValue("@CategoryID", product.categoryID);
                MessageBox.Show($"Inserting Product: {product.productName}, CategoryID: {product.categoryID}");

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"DELETE FROM Products WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProduct(Product product)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            UPDATE Products SET
                ProductName = @ProductName,
                Barcode = @Barcode,
                Price = @Price,
                CostPrice = @CostPrice,
                CategoryID = @CategoryID
            WHERE ProductID = @ProductID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ProductID", product.productID);
                cmd.Parameters.AddWithValue("@ProductName", product.productName);
                cmd.Parameters.AddWithValue("@Barcode", product.productBarcode);
                cmd.Parameters.AddWithValue("@Price", product.unitPrice);
                cmd.Parameters.AddWithValue("@CostPrice", product.unitCost);
                cmd.Parameters.AddWithValue("@CategoryID", product.categoryID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}