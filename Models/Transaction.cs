using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal totalAmount { get; set; }
        public List<TransactionItem> items { get; set; }

        public string cashierName { get; set; }

        public Transaction(int transactionID, DateTime transactionDate, decimal totalAmount, List<TransactionItem> items, string cashierName)
        {
            this.transactionID = transactionID;
            this.transactionDate = transactionDate;
            this.totalAmount = totalAmount;
            this.items = items;
            this.cashierName = cashierName;
        }
    }
}
