using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ElectricCar : Car
    {
        public int BattaryCapacity;

        public void Charge()
        {
            Console.WriteLine("----Charging electric Car----");
            Console.WriteLine("Charge : " + BattaryCapacity);
        }
    }
}
