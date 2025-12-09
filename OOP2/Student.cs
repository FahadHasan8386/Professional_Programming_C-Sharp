using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Student : User
    {
        public int Id;
        public Course EnrolledCourse;
        public Payment StudentPayment;
        public override void ShowProfile()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Id   : " + Id);
        }

        public void ShowDetails()
        {
            EnrolledCourse.ShowCource();
            StudentPayment.Pay();
        }
    }
}
