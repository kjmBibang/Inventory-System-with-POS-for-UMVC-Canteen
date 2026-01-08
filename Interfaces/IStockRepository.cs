using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Interfaces
{
    public interface IStockRepository
    {
        void AddStockMovement(StockMovement movement);
        void AddStockByProductId(int productId, int quantity);
        List<StockMovement> GetAllStockMovements();
        void ReduceStockByBarcode(string barcode,int quantity);
        void AddStockByBarcode(string barcode, int quantity);
    }
}
