using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        // ১. IQueryable: ডাটাবেস লেভেলে ফিল্টারিং (সবচেয়ে ফাস্ট)
        // ধরুন db.Products-এ ৫০০০ আইটেম আছে
        using (var db = new MyDbContext())
        {
            Console.WriteLine("--- IQueryable Execution ---");

            IQueryable<Product> query = db.Products
                                        .Where(p => p.Category == "Electronics")
                                        .Where(p => p.Price > 500);

            // এই পর্যন্ত ডাটাবেসে কোনো কোয়েরি যায়নি।
            // নিচের লাইনটি যখন এক্সিকিউট হবে, তখন SQL তৈরি হয়ে ডাটাবেসে যাবে।
            var fastResults = query.ToList();
            // SQL: SELECT * FROM Products WHERE Category = 'Electronics' AND Price > 500
        }

        // ---------------------------------------------------------

        // ২. IEnumerable: মেমোরিতে ডেটা ফিল্টারিং
        List<Product> localProducts = GetLocalStock(); // কিছু ডামি ডেটা

        Console.WriteLine("\n--- IEnumerable Execution ---");

        IEnumerable<Product> filteredLocal = localProducts
                                             .Where(p => p.Name.StartsWith("IPhone"));

        foreach (var item in filteredLocal)
        {
            Console.WriteLine($"Found: {item.Name}");
        }

        // ---------------------------------------------------------

        // ৩. List<T>: ডেটা অ্যাড বা রিমুভ করার জন্য (Dynamic Array)
        Console.WriteLine("\n--- List<T> Operations ---");

        List<Product> shoppingCart = new List<Product>();

        shoppingCart.Add(new Product { Id = 1, Name = "Laptop", Price = 1200 });
        shoppingCart.Add(new Product { Id = 2, Name = "Mouse", Price = 20 });

        // লিস্টে ডেটা সংখ্যা গুনে দেখা
        Console.WriteLine($"Items in cart: {shoppingCart.Count}");
    }

    public static List<Product> GetLocalStock()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "IPhone 15", Category = "Electronics", Price = 999 },
            new Product { Id = 2, Name = "Samsung S23", Category = "Electronics", Price = 899 }
        };
    }
}