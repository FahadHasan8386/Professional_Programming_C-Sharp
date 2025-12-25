using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudentManagementSystem.Models
{
    partial class Student
    {
        public void Print()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Admission: {AddmissionDate.ToShortDateString()}");

        }
    }
}
