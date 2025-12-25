using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudentManagementSystem.Models
{
    // ================= STRUCT =================
    struct Address
    {
        public string City;
        public string Country;

        public void Show()
        {
            Console.WriteLine($"Address : {City}, {Country}");
        }
    }
}
