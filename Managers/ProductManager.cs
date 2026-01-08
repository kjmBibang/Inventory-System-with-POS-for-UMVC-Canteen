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
        IProductRepository _repo;
        public ProductManager(IProductRepository productRepo) 
        { 
            this._repo = productRepo;
        }
        // ================= BUSINESS LAYER =================
        public List<Product> SearchProducts(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<Product>();

            return _repo.SearchProductsByName(keyword);
        }

        public bool IsProductAvailable(Product product)
        {
            return product != null && product.stock > 0;
        }

        public void ReduceProductStock(string barcode, int quantity)
        {
            _repo.ReduceStock(barcode,quantity);
        }

        public string GetIDFromBarcode(string barcode)
        {
            Product product = _repo.LoadProductByBarcode(barcode);
            return product?.productBarcode;
        }

        /*public TransactionItem ProductSnapshot(Product product, int quantity)
        {
            return null;
        }*/
        public List<Product> LoadInventory()
        {
            return _repo.GetAllProductsWithCategory();
        }
        public List<Product> GetCriticalStock(int threshold = 20)
        {
            return _repo.GetCriticalStockProducts(threshold);
        }
        public void AddProduct(Product product)
        {
            _repo.AddProduct(product);
        }
        public int GetOrCreateCategory(string categoryName)
        {
            return _repo.GetOrCreateCategory(categoryName);
        }
        public void DeleteProduct(int productId)
        {
            _repo.DeleteProduct(productId);
        }
        public void UpdateProduct(Product product)
        {
            _repo.UpdateProduct(product);
        }
    }
}