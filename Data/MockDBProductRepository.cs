using Inventory_System_with_POS_for_UMVC_Canteen.Interfaces;
using Inventory_System_with_POS_for_UMVC_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class MockDBProductRepository : IProductRepository
{
    private static List<Product> _products = new List<Product>();
    private static Dictionary<int, string> _categories = new Dictionary<int, string>();

    private static int _nextProductId = 1;
    private static int _nextCategoryId = 1;

    // 👇 THIS RUNS ONCE
    static MockDBProductRepository()
    {
        // Seed categories
        int dairyId = AddCategoryInternal("Dairy");
        int snacksId = AddCategoryInternal("Snacks");
        int drinksId = AddCategoryInternal("Drinks");

        // Seed products
        _products.Add(new Product
        {
            productID = _nextProductId++,
            productName = "Milk 1L",
            productBarcode = "111111",
            unitPrice = 65,
            unitCost = 50,
            stock = 25,
            categoryID = dairyId
        });

        _products.Add(new Product
        {
            productID = _nextProductId++,
            productName = "Cheese Slice",
            productBarcode = "222222",
            unitPrice = 20,
            unitCost = 12,
            stock = 8, // critical stock
            categoryID = dairyId
        });

        _products.Add(new Product
        {
            productID = _nextProductId++,
            productName = "Potato Chips",
            productBarcode = "333333",
            unitPrice = 30,
            unitCost = 18,
            stock = 40,
            categoryID = snacksId
        });

        _products.Add(new Product
        {
            productID = _nextProductId++,
            productName = "Cola Can",
            productBarcode = "444444",
            unitPrice = 35,
            unitCost = 22,
            stock = 15,
            categoryID = drinksId
        });
    }

    // helper ONLY for seeding
    private static int AddCategoryInternal(string name)
    {
        int id = _nextCategoryId++;
        _categories[id] = name;
        return id;
    }

    // ================= REPO METHODS =================

    public List<Product> SearchProductsByName(string keyword)
    {
        return _products
            .Where(p => p.productName != null
                && p.productName
                    .IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                && p.stock > 0)
            .Take(10)
            .ToList();
    }

    public Product LoadProductByBarcode(string barcode)
    {
        return _products.FirstOrDefault(p => p.productBarcode == barcode);
    }

    public List<Product> GetAllProductsWithCategory()
    {
        return _products.Select(p =>
        {
            p.categoryName = _categories.TryGetValue(p.categoryID, out var name)
                ? name
                : "";
            return p;
        }).ToList();
    }

    public List<Product> GetCriticalStockProducts(int threshold)
    {
        return _products.Where(p => p.stock < threshold).ToList();
    }

    public int GetOrCreateCategory(string categoryName)
    {
        var existing = _categories
            .FirstOrDefault(c => c.Value.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

        if (!existing.Equals(default(KeyValuePair<int, string>)))
            return existing.Key;

        int newId = _nextCategoryId++;
        _categories[newId] = categoryName.Trim();
        return newId;
    }

    public void AddProduct(Product product)
    {
        product.productID = _nextProductId++;
        _products.Add(product);
    }

    public void DeleteProduct(int productId)
    {
        var product = _products.FirstOrDefault(p => p.productID == productId);
        if (product != null)
            _products.Remove(product);
    }

    public void UpdateProduct(Product product)
    {
        var existing = _products.FirstOrDefault(p => p.productID == product.productID);
        if (existing == null) return;

        existing.productName = product.productName;
        existing.productBarcode = product.productBarcode;
        existing.unitPrice = product.unitPrice;
        existing.unitCost = product.unitCost;
        existing.categoryID = product.categoryID;
    }

    public void ReduceStock(string barcode, int quantity)
    {
        var product = LoadProductByBarcode(barcode);
        if (product != null)
            product.stock -= quantity;
    }

    public void AddStock(string barcode, int quantity)
    {
        var product = LoadProductByBarcode(barcode);
        if (product != null)
            product.stock += quantity;
    }

    // required but unused
    public Product GetProduct(string id) => null;
    public void UpdateStock(string id) { }
}
