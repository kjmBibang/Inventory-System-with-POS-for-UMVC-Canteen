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
                        (TransactionDate, TotalAmount, CashierName)
                        VALUES (@Date, @Total, @Cashier);
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

        public Transaction GetTransaction() 
        { 
            return null;

        }
        public Transaction StoreTransaction(Transaction transaction) 
        {
            UpdateTransactionStatus(transaction.transactionID, transaction.status, transaction.approvedBy);
            return transaction;

        }
        public void UpdateTransactionStatus(int transactionId, TransactionStatus status, string approvedBy)
        {
            using (SqlConnection con = new SqlConnection(serverHelper.GetConnectionString()))
            {
                string query = @"
            UPDATE Transactions
            SET TransactionStatusID = @Status,
                ApprovedBy = @ApprovedBy,
                StatusChangedAt = @Now
            WHERE TransactionID = @TransactionID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionId);
                    cmd.Parameters.AddWithValue("@Status", (int)status);
                    cmd.Parameters.AddWithValue("@ApprovedBy", approvedBy ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Now", DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Transaction> GetAllTransactions()
        {
            var transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(serverHelper.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT 
                    TransactionID,
                    TransactionDate,
                    TotalAmount,
                    CashierName,
                    TransactionStatusID,
                    ApprovedBy,
                    StatusChangedAt
                FROM Transactions
                ORDER BY TransactionDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["StatusChangedAt"] == DBNull.Value)
                        {
                            transactions.Add(new Transaction(
                            transactionID: Convert.ToInt32(reader["TransactionID"]),
                            transactionDate: Convert.ToDateTime(reader["TransactionDate"]),
                            totalAmount: Convert.ToDecimal(reader["TotalAmount"]),
                            items: null, // NOT needed for history grid
                            cashierName: reader["CashierName"].ToString(),
                            status: (TransactionStatus)Convert.ToInt32(reader["TransactionStatusID"]),
                            approvedBy: reader["ApprovedBy"] == DBNull.Value ? null : reader["ApprovedBy"].ToString(),
                            statusChangedAt: null
                        ));
                        }
                        else
                        {
                            transactions.Add(new Transaction(
                            transactionID: Convert.ToInt32(reader["TransactionID"]),
                            transactionDate: Convert.ToDateTime(reader["TransactionDate"]),
                            totalAmount: Convert.ToDecimal(reader["TotalAmount"]),
                            items: null, // NOT needed for history grid
                            cashierName: reader["CashierName"].ToString(),
                            status: (TransactionStatus)Convert.ToInt32(reader["TransactionStatusID"]),
                            approvedBy: reader["ApprovedBy"] == DBNull.Value ? null : reader["ApprovedBy"].ToString(),
                            statusChangedAt: Convert.ToDateTime(reader["StatusChangedAt"])
                        ));
                        }
                    }
                }
            }

            return transactions;
        }
    }
}
