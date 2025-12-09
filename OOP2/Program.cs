using OOP2;

static void Main()
{
    Course c = new Course("C#", 5);

    Payment p = new Payment();
    p.Amount = 5000;

    PremiumStudent ps = new PremiumStudent();
    ps.Name = "Fahad";
    ps.Id = 22;
    ps.Discount = 400;

    ps.EnrolledCourse = c;
    ps.StudentPayment = p;

    User u = ps;

    u.ShowProfile();
    ps.ShowDetails();
    p.Pay("Bikash");


}