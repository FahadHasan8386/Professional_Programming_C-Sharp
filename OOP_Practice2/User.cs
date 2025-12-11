using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class User
    {
        public string Name { get; set; }    
        public string Email { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name  : " + Name);
            Console.WriteLine("Email : " + Email);
        }
    }
}
