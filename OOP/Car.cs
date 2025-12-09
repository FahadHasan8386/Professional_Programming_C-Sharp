using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        public string Model;
        public int Year;
        public Brand CarBrand;//Association
        public PriceCar PriceCar;//Association
        
        public void ShowCarInfo()
        {
            Console.WriteLine("Car started");
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Year : " + Year);

            Console.WriteLine("---- Brand Info ----");
            CarBrand.ShowBrandInfo();

            Console.WriteLine("---- Total Price ----");
            PriceCar.ShowTotalPrice();
           
        }
    }
}
