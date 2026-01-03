using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class TransactionItem
    {
        public int transactionItemID { get; set; }
        public int transactionID { get; set; }
        public int productID { get; set; }
        public decimal unitPrice { get; set; }
        public int quantity { get; set; }
        public decimal subTotal { get; set; }

        public string barcode { get; set; }
        public string productName { get; set; }

        public TransactionItem(int transactionItemID, int transactionID, int productID, decimal unitPrice, int quantity, decimal subTotal, string barcode, string productName)
        {
            this.transactionItemID = transactionItemID;
            this.transactionID = transactionID;
            this.productID = productID;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.subTotal = subTotal;
            this.barcode = barcode;
            this.productName = productName;
        }
    }
}
