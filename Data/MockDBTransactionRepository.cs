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

            // Initialize refund properties
            transaction.isRefunded = false;
            transaction.refundDate = null;
            transaction.refundedBy = null;

            // Store in memory
            transactions.Add(transaction);

            // Return the new TransactionID
            return transaction.transactionID;
        }

        public Transaction GetTransactionById(int transactionId)
        {
            // Find transaction by ID
            var transaction = transactions.FirstOrDefault(t => t.transactionID == transactionId);

            if (transaction == null)
                return null;

            // Return a copy to avoid direct reference manipulation
            return new Transaction(
                transactionID: transaction.transactionID,
                transactionDate: transaction.transactionDate,
                totalAmount: transaction.totalAmount,
                items: new List<TransactionItem>(transaction.items), // Create new list with same items
                cashierName: transaction.cashierName,
                isRefunded: transaction.isRefunded,
                refundDate: transaction.refundDate,
                refundedBy: transaction.refundedBy
            );
        }

        public void MarkAsRefunded(int transactionId, string refundedBy)
        {
            var transaction = transactions.FirstOrDefault(t => t.transactionID == transactionId);

            if (transaction == null)
                throw new Exception($"Transaction #{transactionId} not found");

            if (transaction.isRefunded)
                throw new Exception($"Transaction #{transactionId} has already been refunded");

            // Mark as refunded
            transaction.isRefunded = true;
            transaction.refundDate = DateTime.Now;
            transaction.refundedBy = refundedBy;
        }

        public bool IsTransactionRefunded(int transactionId)
        {
            var transaction = transactions.FirstOrDefault(t => t.transactionID == transactionId);

            if (transaction == null)
                return false;

            return transaction.isRefunded;
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

        // Optional: clear all transactions (useful for testing)
        public void ClearAllTransactions()
        {
            transactions.Clear();
            transactionIdCounter = 1;
            transactionItemIdCounter = 1;
        }

        // Optional: get transactions by date range (useful for reports)
        public List<Transaction> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return transactions
                .Where(t => t.transactionDate >= startDate && t.transactionDate <= endDate)
                .ToList();
        }

        // Optional: get all refunded transactions
        public List<Transaction> GetRefundedTransactions()
        {
            return transactions.Where(t => t.isRefunded).ToList();
        }

        // Optional: get transaction count
        public int GetTransactionCount()
        {
            return transactions.Count;
        }
    }
}