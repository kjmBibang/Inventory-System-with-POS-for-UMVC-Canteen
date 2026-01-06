using Inventory_System_with_POS_for_UMVC_Canteen.Data;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Managers
{
    public class TransactionManager
    {
        private ITransactionRepository transactionRepository;
        private IProductRepository productRepository;

        public TransactionManager(ITransactionRepository transactionRepository,
                                  IProductRepository productRepository = null)
        {
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;
        }

        public int ProcessTransaction(Transaction transaction)
        {
            return transactionRepository.CreateTransaction(transaction);
        }

        // ADD THESE METHODS FOR REFUND LOGIC
        public Transaction GetTransactionById(int transactionId)
        {
            return transactionRepository.GetTransactionById(transactionId);
        }

        public void ProcessRefund(int transactionId, string refundedBy, IProductRepository productRepo)
        {
            // Get the transaction
            Transaction transaction = transactionRepository.GetTransactionById(transactionId);

            if (transaction == null)
                throw new Exception("Transaction not found");

            if (transaction.isRefunded)
                throw new Exception("Transaction has already been refunded");

            // Return stock for all items
            foreach (var item in transaction.items)
            {
                productRepo.ReduceStock(item.barcode, -item.quantity); // Negative to add back
            }

            // Mark as refunded
            transactionRepository.MarkAsRefunded(transactionId, refundedBy);
        }

        public bool IsTransactionRefunded(int transactionId)
        {
            return transactionRepository.IsTransactionRefunded(transactionId);
        }

        public TransactionManager CreateTransaction()
        {
            return null;
        }

        public TransactionManager SearchTransaction()
        {
            return null;
        }

        public void ClearTransaction()
        {
            // Implementation to clear transactions
        }
    }
}