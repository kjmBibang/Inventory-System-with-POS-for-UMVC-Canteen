
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Product
    {
        private int productID { get; set; }
        private int productBarcode { get; set; }
        private string productName { get; set; }
        private decimal unitCost { get; set; }
        private decimal unitPrice { get; set; }
        private int categoryID { get; set; }
        private int stock { get; set; }

        public Product(int productID, int prodcutBarcode, string productName, decimal unitCost, decimal unitPrice, int categoryID, int stock)
        {
            this.productID = productID;
            this.productBarcode = prodcutBarcode;
            this.productName = productName;
            this.unitCost = unitCost;
            this.unitPrice = unitPrice;
            this.categoryID = categoryID;
            this.stock = stock;
        }

    }
}
