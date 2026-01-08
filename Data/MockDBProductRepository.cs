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
                new Product { productBarcode = "480001001", productName = "Coca-Cola 330ml", unitPrice = 20.00m, stock = 87 },
                new Product { productBarcode = "480001002", productName = "Pepsi 330ml", unitPrice = 20.00m, stock = 100 },
                new Product { productBarcode = "480001003", productName = "Bottled Water 500ml", unitPrice = 15.00m, stock = 161 },
                new Product { productBarcode = "480001004", productName = "Orange Juice 1L", unitPrice = 85.00m, stock = 40 },
                new Product { productBarcode = "480002001", productName = "Potato Chips", unitPrice = 35.00m, stock = 75 },
                new Product { productBarcode = "480002002", productName = "Chocolate Bar", unitPrice = 25.00m, stock = 90 },
                new Product { productBarcode = "480002003", productName = "Biscuits", unitPrice = 30.00m, stock = 60 },
                new Product { productBarcode = "480002004", productName = "Cup Noodles", unitPrice = 28.00m, stock = 110 },
                new Product { productBarcode = "480003001", productName = "Fresh Milk 1L", unitPrice = 95.00m, stock = 35 },
                new Product { productBarcode = "480003002", productName = "Chocolate Milk 250ml", unitPrice = 28.00m, stock = 80 },
                new Product { productBarcode = "480003003", productName = "Butter 200g", unitPrice = 120.00m, stock = 25 },
                new Product { productBarcode = "480003004", productName = "Cheese Slices", unitPrice = 110.00m, stock = 30 },
                new Product { productBarcode = "480004001", productName = "Canned Sardines", unitPrice = 32.00m, stock = 140 },
                new Product { productBarcode = "480004002", productName = "Canned Tuna", unitPrice = 45.00m, stock = 95 },
                new Product { productBarcode = "480004003", productName = "Canned Corn", unitPrice = 40.00m, stock = 70 },
                new Product { productBarcode = "480004004", productName = "Canned Beans", unitPrice = 38.00m, stock = 65 },
                new Product { productBarcode = "480005001", productName = "Shampoo Sachet", unitPrice = 8.00m, stock = 300 },
                new Product { productBarcode = "480005002", productName = "Soap Bar", unitPrice = 28.00m, stock = 150 },
                new Product { productBarcode = "480005003", productName = "Toothpaste 100g", unitPrice = 75.00m, stock = 45 },
                new Product { productBarcode = "480005004", productName = "Facial Wash", unitPrice = 120.00m, stock = 35 }
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

        public List<Product> GetAllProductsWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetCriticalStockProducts(int threshold)
        {
            throw new NotImplementedException();
        }

        public int GetOrCreateCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
