using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Utilities
{
    public static class TaxCalculator
    {
        public static double CalculateTax(double salary)
        {
            return salary * 0.10;
        }
    }
}
