using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Practice
{
    public class Instructor : User
    {
       public override void ShowProfile()
       {
          Console.WriteLine($"Instructor Name: {name}, Id: {id}");
       }
    }

   
}
