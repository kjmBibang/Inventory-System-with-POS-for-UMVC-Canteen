using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class StockMovement
    {
        public int StockMovementID { get; set; }

        public int ProductID { get; set; }

        // Positive = add stock, Negative = reduce stock
        public int QuantityChange { get; set; }

        public StockMovementType MovementType { get; set; }

        // Optional references
        //public int? TransactionID { get; set; }
        //public int? SupplierID { get; set; }

        public string Reason { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }   // cashier/admin username

        public StockMovement()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
