using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class PremiumStudent : Student
    {
        public int Discount;

        //Runtime Polymorphism
        public override void ShowProfile()
        {
            Console.WriteLine("Premium Student : " + Name);
            Console.WriteLine("Discount        : " + Discount);
        }
    }
}
