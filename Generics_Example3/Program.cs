using Generics_Example3;

public class Progam
{
    static void Main()
    {
        var electroManager = new ProductManager<Electronics>();
        electroManager.AddProduct(new Electronics { Id = 11, Name = "Laptop", Price = 1000 });
        electroManager.AddProduct(new Electronics { Id = 11, Name = "Laptop", Price = 25000});

        var expensiveElectronics = electroManager.FilterProduct(q => q.Price > 9000);

      
        var clothManager = new ProductManager<Clothing>();
        clothManager.AddProduct(new Clothing { Id = 121, Name = "T-Shirt", Price = 2000 });
        clothManager.AddProduct(new Clothing { Id = 122, Name = "T-Shirt", Price = 510 });

        var expensiveClothes = clothManager.FilterProduct(p => p.Price > 1000);


        Printer printer = new Printer();
        foreach (var item in expensiveElectronics)
        {
            printer.PrintDetails(item);
        }

        Printer printer1 = new Printer();
        foreach (var item in expensiveClothes)
        {
            printer1.PrintDetails(item);
        }

    }
}