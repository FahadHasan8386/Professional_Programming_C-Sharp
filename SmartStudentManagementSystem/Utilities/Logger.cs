using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStudentManagementSystem.Utilities
{
    static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[Log in - {DateTime.Now}] {message}");
        }
    }
}
