using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Brand
    {
        public string Name;
        public string Country;

        public void ShowBrandInfo()
        {
            Console.WriteLine("Name : "+ Name);
            Console.WriteLine("Country : "+  Country);
        }
    }
}
