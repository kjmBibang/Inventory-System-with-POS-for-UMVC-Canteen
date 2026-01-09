using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class StockMovement
    {
        public int stockMovementID { get; set; }

        public int productID { get; set; }

        // Positive = add stock, Negative = reduce stock
        public int quantityChange { get; set; }

        public StockMovementType movementType { get; set; }

        // Optional references
        //public int? TransactionID { get; set; }
        //public int? SupplierID { get; set; }
        public int? supplierID { get; set; }
        public string reason { get; set; }
        public string productName { get; set; }
        public string supplierName { get; set; }
        public DateTime createdAt { get; set; }
        public string createdBy { get; set; }   // cashier/admin username

        public StockMovement()
        {
            createdAt = DateTime.Now;
        }
    }
}
