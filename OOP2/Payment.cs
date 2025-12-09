using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Payment
    {
        public int Amount;

        public void Pay()
        {
            Console.WriteLine("Pay amount : " + Amount);
        }
        //Method OverLoading
        public void Pay(string method)
        {
            Console.WriteLine("Paid  : " + Amount + "Using  : " + method);
        }
    }
}
