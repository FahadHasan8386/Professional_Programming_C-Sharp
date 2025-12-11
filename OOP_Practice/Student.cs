using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Practice
{
    public class Student : User
    {
        public override void ShowProfile()
        {
            Console.WriteLine($"Student Name: {name}, Id: {id}");
        }
    }

}
