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
            return null;

        }
    }
}
