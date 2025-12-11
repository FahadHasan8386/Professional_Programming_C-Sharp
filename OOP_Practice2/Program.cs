using OOP_Practice2;

class Program
{
    static void Main()
    {
        Instructor instructor = new Instructor
        {
            Name = "Nazmul Sir",
            Email = "nazmul@aiub.edu",
            Expertise = "Compiler Design"
        };

        Course csharp = new Course("C# Masterclass " , 3000 ,instructor);

        Admin admin = new Admin { Name = "System Admin", Email = "admin@site.com" };
        admin.ApproveCourse(csharp);

        Student s1 = new Student
        {
            Name = "Fahad Hasan",
            Email = "fahad@student.aiub.edu",
            MyWallet = new Wallet(),
            PaymentMethod = new BkashPayment()
        };

        s1.MyWallet.AddMoney(3000);

        Enrollment enroll = new Enrollment
        {
            Student = s1,
            Course = csharp
        };
        enroll.Enroll();
    }
}