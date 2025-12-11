using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice2
{
    public class Admin : User
    {
        public void ApproveCourse(Course c)
        {
            c.IsApproved = true;
            Console.WriteLine($"{c.Title} approved by Admin");
        }
    }
}
