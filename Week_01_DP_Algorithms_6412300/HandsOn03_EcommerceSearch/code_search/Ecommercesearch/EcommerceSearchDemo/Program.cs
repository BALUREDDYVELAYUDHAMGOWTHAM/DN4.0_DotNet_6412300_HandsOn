using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var database = new ProductDatabase();
        var searchService = new SearchService();

        Console.WriteLine("Welcome to E-Commerce Search Engine");
        Console.Write("Enter search keyword: ");
        string keyword = Console.ReadLine();

        List<Product> results = searchService.Search(keyword, database.GetAllProducts());

        if (results.Count == 0)
        {
            Console.WriteLine("No products found.");
        }
        else
        {
            Console.WriteLine("\nResults:");
            foreach (var product in results)
            {
                product.Display();
            }
        }
    }
}
