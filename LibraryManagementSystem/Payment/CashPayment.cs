using LibraryManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem.Payment
{
    public class CashPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid Amount {amount} by Cash");
        }
    }
}
