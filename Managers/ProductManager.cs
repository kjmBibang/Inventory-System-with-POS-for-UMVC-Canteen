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
        public string GetIDFromBarcode(string barcode)
        {
            return null;
        }
        public TransactionItem ProductSnapshot(Product product, int quantity) 
        {
            return null;
        }
        public Product GetProductFromBarcode(string barcode)
        {
            Product product = _repo.LoadProductByBarcode(barcode);
            
            return product;
        }
        public void ReduceStock(string barcode)
        {
            _repo.ReduceStock(barcode);
        }
    }
}
