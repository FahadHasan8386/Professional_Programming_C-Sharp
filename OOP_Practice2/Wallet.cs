using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class Wallet
    {
        private double balance; //Encapsulation

        public double Balance => balance;// Read-only property

        public void AddMoney(double amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("Invaild Amount !");
                return;
            }
            balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                return true;
            }

            Console.WriteLine("Not enough balance !");
            return false;
        }
    }
}
