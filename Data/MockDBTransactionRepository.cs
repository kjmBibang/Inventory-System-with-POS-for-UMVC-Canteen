using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBTransactionRepository : ITransactionRepository
    {
        private readonly List<Transaction> transactions = new List<Transaction>();
        private int transactionIdCounter = 1;
        private int transactionItemIdCounter = 1;

        public int CreateTransaction(Transaction transaction)
        {
            if (transaction == null || transaction.items == null || transaction.items.Count == 0)
                throw new ArgumentException("Transaction or items cannot be null or empty");

            // Assign a TransactionID
            transaction.transactionID = transactionIdCounter++;

            // Assign TransactionItemID to each item
            foreach (var item in transaction.items)
            {
                item.transactionItemID = transactionItemIdCounter++;
                item.transactionID = transaction.transactionID; // link back to transaction
            }

            // Store in memory
            transactions.Add(transaction);

            // Return the new TransactionID
            return transaction.transactionID;
        }

        public Transaction GetTransaction()
        {
            // mimic SQLTransactionRepository behavior, returns transaction by ID or null
            return null;
        }

        public Transaction StoreTransaction(Transaction transaction)
        {
            // mimic SQL stub: just return the transaction, no DB involved
            return transaction;
        }

        // Optional: get all transactions (useful for testing)
        public List<Transaction> GetAllTransactions()
        {
            return transactions.ToList();
        }
    }
}
