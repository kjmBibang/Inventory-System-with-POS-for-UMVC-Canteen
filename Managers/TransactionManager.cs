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
        private readonly ITransactionRepository _transactionRepo;
        private readonly IProductRepository _productRepo;
        IStockRepository stockRepository;
        public TransactionManager CreateTransaction() 
        {
            return null;
        }
       public TransactionManager SearchTransaction()
        {
            // Implementation to search for a transaction
            return null;
        }
        public TransactionManager(ITransactionRepository transactionRepo, IProductRepository productRepo, IStockRepository stockRepository)
        {
            _transactionRepo = transactionRepo;
            _productRepo = productRepo;
            this.stockRepository = stockRepository;
        }

        public void ClearTransaction()
        {
            // Implementation to clear transactions
        }


        public int ProcessTransaction(Transaction transaction)
        {
            return _transactionRepo.CreateTransaction(transaction);
        }

        public void VoidItem(Transaction transaction, TransactionItem item, User authorizedBy)
        {
            if (!UserIsAdmin(authorizedBy))
                throw new UnauthorizedAccessException("Admin approval required.");

            // Restore stock
            stockRepository.AddStockByBarcode(item.barcode, item.quantity); // negative reduces less → adds back

            // Remove from transaction
            transaction.items.Remove(item);

            // If no items left, void transaction
            if (!transaction.items.Any())
                VoidTransaction(transaction, authorizedBy);
        }

        public void VoidTransaction(Transaction transaction, User authorizedBy)
        {
            if (!UserIsAdmin(authorizedBy))
                throw new UnauthorizedAccessException("Admin approval required.");

            // Restore stock for all items
            foreach (var item in transaction.items)
                stockRepository.AddStockByBarcode(item.barcode, item.quantity);

            // Update status
            transaction.status = TransactionStatus.Voided;
            transaction.approvedBy = authorizedBy.username;
            transaction.statusChangedAt = DateTime.Now;

            // Persist changes
            _transactionRepo.StoreTransaction(transaction);
        }

        public void RefundTransaction(Transaction transaction, User authorizedBy)
        {
            if (!UserIsAdmin(authorizedBy))
                throw new UnauthorizedAccessException("Admin approval required.");

            // Restore stock
            foreach (var item in transaction.items)
                stockRepository.AddStockByBarcode(item.barcode, item.quantity);

            transaction.status = TransactionStatus.Refunded;
            transaction.approvedBy = authorizedBy.username;
            transaction.statusChangedAt = DateTime.Now;

            _transactionRepo.StoreTransaction(transaction);
        }

        private bool UserIsAdmin(User user)
        {
            return user != null && user.roleID == 1; // roleID 1 = admin
        }

    }
}
