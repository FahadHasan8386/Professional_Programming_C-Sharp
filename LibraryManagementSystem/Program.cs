
using LibraryManagementSystem;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Payment;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

class Program
{
    public static void Main()
    {
        LibraryUser us = new Student
        {
            Name = "Fahad",
            
        };
       
        double fine = us.calculateFine(3);

        IPayment payment = new CashPayment();
        payment.Pay(fine);
    }
}