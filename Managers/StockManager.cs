using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Managers
{
    public class StockManager
    {
        private readonly IStockRepository _stockRepository;
        private readonly ISupplierRepository _supplierRepository;

        public StockManager(
            IStockRepository stockRepository,
            ISupplierRepository supplierRepository)
        {
            _stockRepository = stockRepository;
            _supplierRepository = supplierRepository;
        }

        public List<Supplier> GetSuppliers()
        {
            return _supplierRepository.GetAllSuppliers();
        }

        public void StockIn(int productID, int quantity, int supplierId, string createdBy, string reason)
        {
            _stockRepository.AddStockByProductId(productID, quantity);

            _stockRepository.AddStockMovement(new StockMovement
            {
                productID = productID,
                quantityChange = quantity,
                supplierID = supplierId,
                movementType = StockMovementType.StockIn,
                reason = reason,
                createdAt = DateTime.Now,
                createdBy = createdBy
            });
        }
        public List<StockMovement> GetAllStockMovements()
        {
            return _stockRepository.GetAllStockMovements();
        }

    }
}
