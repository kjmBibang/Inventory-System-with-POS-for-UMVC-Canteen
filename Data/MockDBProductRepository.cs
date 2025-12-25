using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBProductRepository 
    {
        public Product GetProduct(string id)
        {
            return null;
        }
        public void UpdateStock(string id)
        {

        }
    }
}