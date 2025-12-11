using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Wallet
    {
        private int Balance;

        public Wallet(int initialBalance)
        {
            if(initialBalance < 0)
            {
                Console.WriteLine("Invalid Balance");
            }
            Balance = initialBalance;
        }

        public void AddBalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid Amount");
                return;
            }

            Balance += amount;
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
