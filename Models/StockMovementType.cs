using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public enum StockMovementType
    {
        StockIn = 1,
        StockOut = 2,
        Sale = 3,
        Refund = 4,
        Adjustment = 5
    }
}
