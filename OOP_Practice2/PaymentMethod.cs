using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(double amount);
    }

    public class BkashPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} Tk via Bkash.");
        }
    }
    public class NagadPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} Tk via Nagad.");
        }
    }
    public class CashPayment : PaymentMethod
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paying {amount} Tk via CAsh.");
        }
    }
}
