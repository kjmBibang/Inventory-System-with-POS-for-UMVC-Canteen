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
        public ITransactionRepository transactionRepository;

        public TransactionManager CreateTransaction() 
        {
            return null;
        }
       public TransactionManager SearchTransaction()
        {
            // Implementation to search for a transaction
            return null;
        }
        public TransactionManager(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public void ClearTransaction()
        {
            // Implementation to clear transactions
        }


        public int ProcessTransaction(Transaction transaction)
        {
            return transactionRepository.CreateTransaction(transaction);
        }
    }
}
