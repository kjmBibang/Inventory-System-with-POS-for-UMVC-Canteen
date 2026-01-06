using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction GetTransaction();
        Transaction StoreTransaction(Transaction transaction);
        int CreateTransaction(Transaction transaction);

        // ADD THESE FOR REFUND
        Transaction GetTransactionById(int transactionId);
        void MarkAsRefunded(int transactionId, string refundedBy);
        bool IsTransactionRefunded(int transactionId);
    }
}