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
    public class SQLTransactionRepository : ITransactionRepository
    {
        IServerHelper serverHelper = new SQLHelper();

        public int CreateTransaction(Transaction transaction)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                con.Open();

                using (SqlTransaction sqlTran = con.BeginTransaction())
                {
                    try
                    {
                        int transactionId;

                        // 1. Insert Transaction (header)
                        string insertTransaction = @"
                        INSERT INTO dbo.Transactions
                        (TransactionDate, TotalAmount, CashierName, IsRefunded)
                        VALUES (@Date, @Total, @Cashier, 0);
                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertTransaction, con, sqlTran))
                        {
                            cmd.Parameters.AddWithValue("@Date", transaction.transactionDate);
                            cmd.Parameters.AddWithValue("@Total", transaction.totalAmount);
                            cmd.Parameters.AddWithValue("@Cashier", transaction.cashierName);

                            transactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Insert Transaction Items
                        string insertItem = @"
                        INSERT INTO dbo.TransactionItems
                        (TransactionID, Barcode, ProductName, UnitPrice, Quantity, Subtotal)
                        VALUES (@TransactionID, @Barcode, @Name, @Price, @Qty, @Subtotal);";

                        foreach (var item in transaction.items)
                        {
                            using (SqlCommand cmd = new SqlCommand(insertItem, con, sqlTran))
                            {
                                cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                                cmd.Parameters.AddWithValue("@Barcode", item.barcode);
                                cmd.Parameters.AddWithValue("@Name", item.productName);
                                cmd.Parameters.AddWithValue("@Price", item.unitPrice);
                                cmd.Parameters.AddWithValue("@Qty", item.quantity);
                                cmd.Parameters.AddWithValue("@Subtotal", item.subTotal);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        sqlTran.Commit();
                        return transactionId;
                    }
                    catch
                    {
                        sqlTran.Rollback();
                        throw;
                    }
                }
            }
        }

        // ADD THESE METHODS
        public Transaction GetTransactionById(int transactionId)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                con.Open();

                // Get transaction header
                string queryHeader = @"
                    SELECT TransactionID, TransactionDate, TotalAmount, CashierName, 
                           IsRefunded, RefundDate, RefundedBy
                    FROM dbo.Transactions
                    WHERE TransactionID = @TransactionID";

                Transaction transaction = null;

                using (SqlCommand cmd = new SqlCommand(queryHeader, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaction = new Transaction(
                                transactionID: Convert.ToInt32(reader["TransactionID"]),
                                transactionDate: Convert.ToDateTime(reader["TransactionDate"]),
                                totalAmount: Convert.ToDecimal(reader["TotalAmount"]),
                                items: new List<TransactionItem>(),
                                cashierName: reader["CashierName"].ToString(),
                                isRefunded: Convert.ToBoolean(reader["IsRefunded"]),
                                refundDate: reader["RefundDate"] == DBNull.Value ? null : (DateTime?)reader["RefundDate"],
                                refundedBy: reader["RefundedBy"] == DBNull.Value ? null : reader["RefundedBy"].ToString()
                            );
                        }
                    }
                }

                // If transaction not found, return null
                if (transaction == null)
                    return null;

                // Get transaction items
                string queryItems = @"
                    SELECT TransactionItemID, TransactionID, Barcode, ProductName, 
                           UnitPrice, Quantity, Subtotal
                    FROM dbo.TransactionItems
                    WHERE TransactionID = @TransactionID";

                using (SqlCommand cmd = new SqlCommand(queryItems, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transaction.items.Add(new TransactionItem(
                                transactionItemID: Convert.ToInt32(reader["TransactionItemID"]),
                                transactionID: Convert.ToInt32(reader["TransactionID"]),
                                productID: 0, // Not used in this context
                                unitPrice: Convert.ToDecimal(reader["UnitPrice"]),
                                quantity: Convert.ToInt32(reader["Quantity"]),
                                subTotal: Convert.ToDecimal(reader["Subtotal"]),
                                barcode: reader["Barcode"].ToString(),
                                productName: reader["ProductName"].ToString()
                            ));
                        }
                    }
                }

                return transaction;
            }
        }

        public void MarkAsRefunded(int transactionId, string refundedBy)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
                    UPDATE dbo.Transactions
                    SET IsRefunded = 1,
                        RefundDate = GETDATE(),
                        RefundedBy = @RefundedBy
                    WHERE TransactionID = @TransactionID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                    cmd.Parameters.AddWithValue("@RefundedBy", refundedBy);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsTransactionRefunded(int transactionId)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
                    SELECT IsRefunded
                    FROM dbo.Transactions
                    WHERE TransactionID = @TransactionID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return false;

                    return Convert.ToBoolean(result);
                }
            }
        }

        public Transaction GetTransaction()
        {
            return null;
        }

        public Transaction StoreTransaction(Transaction transaction)
        {
            return null;
        }
    }
}