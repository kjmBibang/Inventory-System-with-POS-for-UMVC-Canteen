using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory_System_with_POS_for_UMVC_Canteen.Data
{
    public class MockDBProductRepository : IProductRepository
    {
        private List<Product> products;

        public MockDBProductRepository()
        {
            products = new List<Product>
            {
                new Product("480001001","Coca-Cola 330ml",20.00m,87),
                new Product("480001002","Pepsi 330ml",20.00m,100),
                new Product("480001003","Bottled Water 500ml",15.00m,161),
                new Product("480001004","Orange Juice 1L",85.00m,40),
                new Product("480002001","Potato Chips",35.00m,75),
                new Product("480002002","Chocolate Bar",25.00m,90),
                new Product("480002003","Biscuits",30.00m,60),
                new Product("480002004","Cup Noodles",28.00m,110),
                new Product("480003001","Fresh Milk 1L",95.00m,35),
                new Product("480003002","Chocolate Milk 250ml",28.00m,80),
                new Product("480003003","Butter 200g",120.00m,25),
                new Product("480003004","Cheese Slices",110.00m,30),
                new Product("480004001","Canned Sardines",32.00m,140),
                new Product("480004002","Canned Tuna",45.00m,95),
                new Product("480004003","Canned Corn",40.00m,70),
                new Product("480004004","Canned Beans",38.00m,65),
                new Product("480005001","Shampoo Sachet",8.00m,300),
                new Product("480005002","Soap Bar",28.00m,150),
                new Product("480005003","Toothpaste 100g",75.00m,45),
                new Product("480005004","Facial Wash",120.00m,35)
            };
        }

        public List<Product> SearchProductsByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return new List<Product>();

            return products
                .Where(p => p.productName != null && p.productName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 && p.stock > 0)
                .Take(10)
                .ToList();
        }

        public Product LoadProductByBarcode(string barcode)
        {
            return products.FirstOrDefault(p => p.productBarcode == barcode && p.stock > 0);
        }

        public void ReduceStock(string barcode, int quantity)
        {
            var product = products.FirstOrDefault(p => p.productBarcode == barcode);
            if (product != null)
            {
                product.stock -= quantity;
                if (product.stock < 0) product.stock = 0; // mimic SQL safety
            }
        }

        public Product GetProduct(string id)
        {
            // Not used in POS grid, so return null like SQL version
            return null;
        }

        public void UpdateStock(string id)
        {
            // Not used in POS grid, empty like SQL version
        }

        public void AddStock(string barcode, int quantity)
        {
            var product = products.FirstOrDefault(p => p.productBarcode == barcode);
            if (product != null)
            {
                product.stock += quantity;
                if (product.stock < 0) product.stock = 0; // mimic SQL safety
            }
        }
    }
}
