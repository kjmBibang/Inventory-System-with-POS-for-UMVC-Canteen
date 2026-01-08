using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBTransactionRepository : ITransactionRepository
    {
        private static List<Transaction> _transactions = new List<Transaction>();
        private static int _nextTransactionId = 1;

        public int CreateTransaction(Transaction transaction)
        {
            transaction.transactionID = _nextTransactionId++;
            _transactions.Add(transaction);
            return transaction.transactionID;
        }

        public Transaction StoreTransaction(Transaction transaction)
        {
            UpdateTransactionStatus(
                transaction.transactionID,
                transaction.status,
                transaction.approvedBy
            );
            return transaction;
        }

        public void UpdateTransactionStatus(
            int transactionId,
            TransactionStatus status,
            string approvedBy)
        {
            var txn = _transactions.Find(t => t.transactionID == transactionId);
            if (txn == null) return;

            txn.status = status;
            txn.approvedBy = approvedBy;
            txn.statusChangedAt = DateTime.Now;
        }

        public Transaction GetTransaction()
        {
            return null;
        }
    }
}
