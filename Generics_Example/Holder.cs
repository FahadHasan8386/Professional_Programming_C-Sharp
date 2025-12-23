using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Example
{
    public class Holder<T>
    {
        public T Data;

        public void ShowData()
        {
            Console.WriteLine("Data is : " + Data);
        }
    }
}
