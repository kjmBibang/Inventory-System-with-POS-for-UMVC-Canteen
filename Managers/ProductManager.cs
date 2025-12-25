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
        public ProductManager(IProductRepository productRepo) 
        { 
        
        }
        public string GetIDFromBarcode(string barcode)
        {
            return null;
        }
        public TransactionItem ProductSnapshot(Product quantity) 
        {
            return null;
        }
    }
}
