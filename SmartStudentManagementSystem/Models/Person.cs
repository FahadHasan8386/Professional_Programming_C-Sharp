using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudentManagementSystem.Models
{
    // ================= ABSTRACT CLASS =================
    abstract class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public abstract void ShowRole();

        public void Greet()
        {
            Console.WriteLine($"Hello , I Am {Name}");
        }
    }
}
