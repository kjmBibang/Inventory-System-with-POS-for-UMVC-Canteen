
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productBarcode { get; set; }
        public string productName { get; set; }
        public decimal unitCost { get; set; }
        public decimal unitPrice { get; set; }
        public string categoryName { get; set; }
        public int stock { get; set; }

        //public Product(int productID, string productBarcode, string productName, decimal unitCost, decimal unitPrice, int categoryID, int stock)
        public Product(string productBarcode, string productName, decimal unitPrice, int stock)
        {
            {
                this.productID = productID;
                this.productBarcode = productBarcode;
                this.productName = productName;
                this.unitCost = unitCost;
                this.unitPrice = unitPrice;
                this.categoryName = categoryName;
                this.stock = stock;
            }

        }
    }
}
