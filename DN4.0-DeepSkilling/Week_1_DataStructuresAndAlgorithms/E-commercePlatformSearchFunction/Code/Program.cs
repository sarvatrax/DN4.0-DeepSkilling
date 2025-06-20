using System;
using System.Linq;

class Program
{
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null!;
    }

    static Product BinarySearch(Product[] products, string name)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int compare = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);
            if (compare == 0) return products[mid];
            else if (compare < 0) low = mid + 1;
            else high = mid - 1;
        }

        return null!;
    }

    static void Main()
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Book", "Education"),
            new Product(4, "Phone", "Electronics"),
            new Product(5, "Pen", "Stationery")
        };

        var linearResult = LinearSearch(products, "Pen");
        Console.WriteLine("Linear Search Result: " + (linearResult != null ? linearResult.ToString() : "Not found"));

        var sorted = products.OrderBy(p => p.ProductName).ToArray();
        var binaryResult = BinarySearch(sorted, "Pen");
        Console.WriteLine("Binary Search Result: " + (binaryResult != null ? binaryResult.ToString() : "Not found"));
    }
}
