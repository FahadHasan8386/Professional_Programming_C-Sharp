using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartStudentManagementSystem.Interfaces;

namespace SmartStudentManagementSystem.Models
{
    partial class Student : Person , IPrintable
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public Address Address { get; set; }
        public DateTime AddmissionDate { get; set; } = DateTime.Now;
        public int? Age { get; set; }

        public override void ShowRole()
        {         
            Console.WriteLine($"Role: {Role}");
        }
    }
}
