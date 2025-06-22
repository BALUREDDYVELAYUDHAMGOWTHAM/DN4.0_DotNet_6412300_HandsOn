using System.Collections.Generic;
using System.Linq;

public class SearchService
{
    public List<Product> Search(string keyword, List<Product> products)
    {
        return products
            .Where(p =>
                p.Name.ToLower().Contains(keyword.ToLower()) ||
                p.Description.ToLower().Contains(keyword.ToLower()))
            .ToList();
    }
}
