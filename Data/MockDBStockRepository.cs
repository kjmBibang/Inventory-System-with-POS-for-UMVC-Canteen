using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBStockRepository : IStockRepository
    {
        public void AddStockByBarcode(string barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public void AddStockByProductId(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void AddStockMovement(StockMovement movement)
        {
            // Mock implementation: No operation performed.
        }

        public List<StockMovement> GetAllStockMovements()
        {
            throw new NotImplementedException();
        }

        public void ReduceStockByBarcode(string barcode)
        {
            throw new NotImplementedException();
        }

        public void ReduceStockByBarcode(string barcode, int quantity)
        {
            throw new NotImplementedException();
        }

        public void ReduceStockByProductID(int productID, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
