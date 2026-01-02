using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Interfaces
{
     public interface IProductRepository
    {
        Product GetProduct(string id);
        Product LoadProductByBarcode(string barcode);
        void ReduceStock(string barcode);


    }
}
