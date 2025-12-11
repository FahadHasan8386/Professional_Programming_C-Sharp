using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class Student : User
    {
        public Wallet MyWallet { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
