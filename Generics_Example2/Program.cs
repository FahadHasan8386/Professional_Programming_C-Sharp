using Generics_Example2;

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Id = 1,
            Name = "Fahad"
        };

        Product product = new Product
        {
            Id = 101,
            ProductName = "Laptop"
        };

        Repository<Student> studentRepo = new Repository<Student>();
        studentRepo.Save(student);
        studentRepo.PrintInfo("Student data inserted");

        Repository<Product> productRepo = new Repository<Product>();
        productRepo.Save(product);
        productRepo.PrintInfo(999);
    }
}
