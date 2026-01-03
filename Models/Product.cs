
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
        public string productBarcode { get; set; }
        public string productName { get; set; }
        private decimal unitCost { get; set; }
        public decimal unitPrice { get; set; }
        private int categoryID { get; set; }
        public int stock { get; set; }

        public Product(int productID, string prodcutBarcode, string productName, decimal unitCost, decimal unitPrice, int categoryID, int stock)
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
