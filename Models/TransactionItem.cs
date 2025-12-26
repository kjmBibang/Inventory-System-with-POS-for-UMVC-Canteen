using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class TransactionItem
    {
        private int transactionItemID { get; set; }
        private int transactionID { get; set; }
        private int productID { get; set; }
        private decimal unitPrice { get; set; }
        private int quantity { get; set; }
        private decimal subTotal { get; set; }
    }
}
