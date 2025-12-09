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
        public Brand CarBrand;
        
        public void ShowCarInfo()
        {
            Console.WriteLine("Car started");
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Year : " + Year);

            Console.WriteLine("---- Brand Info ----");
            CarBrand.ShowBrandInfo();

            
           
        }
    }
}
