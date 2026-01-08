using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class PurchaseOrder
    {
        
            public int PurchaseOrderID { get; set; }

            public int SupplierID { get; set; }

            public DateTime OrderDate { get; set; }
            public PurchaseOrderStatus Status { get; set; }

            public decimal TotalCost { get; set; }

            public string CreatedBy { get; set; }

            public PurchaseOrder()
            {
                OrderDate = DateTime.Now;
                Status = PurchaseOrderStatus.Pending;
            }
        
    }
}
