using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class User
    {
        public string name;
        public uint id;
        public virtual void ShowProfile()
        {
            Console.WriteLine("Name" + name + "Id : " + id);
        }
    }
}
