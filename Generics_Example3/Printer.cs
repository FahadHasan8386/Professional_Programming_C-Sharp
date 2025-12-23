using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example3
{
    public class Printer
    {
        public void PrintDetails<T>(T item) where T : Product
        {
            Console.WriteLine("This Product is Expensive");
            Console.WriteLine($"Id : {item.Id} , Name : {item.Name} ,Price : {item.Price}");
        }
    }
}
