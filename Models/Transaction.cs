using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Transaction
    {
        private int transactionID { get; set; }
        private DateTime transactionDate { get; set; }
        private decimal totalAmount { get; set; }
        private List<TransactionItem> items { get; set; }

        public Transaction(int transactionID, DateTime transactionDate, decimal totalAmount, List<TransactionItem> items)
        {
            this.transactionID = transactionID;
            this.transactionDate = transactionDate;
            this.totalAmount = totalAmount;
            this.items = items;
        }
    }
}
