using System.Collections.Generic;

public class ProductDatabase
{
    private List<Product> _products;

    public ProductDatabase()
    {
        _products = new List<Product>
        {
            new Product(1, "Running Shoes", "Comfortable running shoes for all terrain"),
            new Product(2, "Laptop Bag", "Waterproof laptop bag with USB port"),
            new Product(3, "Smartphone", "Latest Android phone with 5G support"),
            new Product(4, "Wireless Headphones", "Bluetooth headphones with noise cancellation"),
            new Product(5, "Sports Shoes", "Durable and lightweight sports shoes")
        };
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
}
