using OOP2;
class Program
{
    static void Main()
    {
        Course c = new Course("C#", 5);
        Course c2 = new Course("c++", 10);

        Payment p = new Payment();
        p.Amount = 5000;

        PremiumStudent ps = new PremiumStudent();
        ps.Name = "Fahad";
        ps.Id = 22;
        ps.Discount = 400;

        PremiumStudent ps2 = new PremiumStudent();
        ps2.Name = "Hasan";
        ps2.Id = 50;
        ps2.Discount = 40;

        ps.EnrolledCourse = c;
        ps.StudentPayment = p;

        ps2.EnrolledCourse = c2;
        ps2.StudentPayment = p;

        User u = ps;

        u.ShowProfile();
        ps.ShowDetails();
        p.Pay("Bikash");

        User u2 = ps2;

        u2.ShowProfile();
        ps2.ShowDetails();
        p.Pay("Cash");
    }
}
