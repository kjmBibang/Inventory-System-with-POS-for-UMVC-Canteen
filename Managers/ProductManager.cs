using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Managers
{
    public class ProductManager
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepo)
        {
            _productRepository = productRepo;
        }

        public Product GetProductByBarcode(string barcode)
        {
            return _productRepository.LoadProductByBarcode(barcode);
        }

        public bool IsProductAvailable(Product product)
        {
            return product != null && product.stock > 0;
        }

        public void ReduceProductStock(string barcode)
        {
            _productRepository.ReduceStock(barcode);
        }

        public string GetIDFromBarcode(string barcode)
        {
            Product product = _productRepository.LoadProductByBarcode(barcode);
            return product?.productBarcode;
        }

        /*public TransactionItem ProductSnapshot(Product product, int quantity)
        {
            if (product == null)
                return null;

            return new TransactionItem
            {
                Barcode = product.productBarcode,
                ProductName = product.productName,
                Price = product.unitPrice,
               
            };
        }*/
    }
}