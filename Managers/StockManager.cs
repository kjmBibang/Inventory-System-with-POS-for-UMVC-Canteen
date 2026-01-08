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
        IProductRepository _productRepository;
        public StockManager(
            IStockRepository stockRepository,
            ISupplierRepository supplierRepository,
            IProductRepository productRepository)
        {
            _stockRepository = stockRepository;
            _supplierRepository = supplierRepository;
            _productRepository = productRepository;
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
        public void StockOut(int productID, int quantity, string reason, string createdBy)
        {
            _stockRepository.ReduceStockByProductID(productID, quantity);

            _stockRepository.AddStockMovement(new StockMovement
            {
                productID = productID,
                quantityChange = -quantity,
                movementType = StockMovementType.StockOut,
                reason = reason,
                createdAt = DateTime.Now,
                createdBy = createdBy,
                supplierID = null
            });
        }
        public void AdjustStock(int productID, int quantityChange, string reason, string createdBy)
        {
            var product = _productRepository.GetProductByID(productID);
            if (product == null) throw new Exception("Product not found.");

            // Update stock
            if (quantityChange > 0)
                _stockRepository.AddStockByProductId(productID, quantityChange);
            else
                _stockRepository.ReduceStockByBarcode(product.productBarcode, -quantityChange);

            // Log movement
            _stockRepository.AddStockMovement(new StockMovement
            {
                productID = productID,
                quantityChange = quantityChange,
                movementType = StockMovementType.Adjustment,
                reason = reason,
                createdAt = DateTime.Now,
                createdBy = createdBy
            });
        }
    }
}
