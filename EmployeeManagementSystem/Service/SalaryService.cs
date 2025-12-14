using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Utilities;

namespace EmployeeManagementSystem.Service
{
    public class SalaryService
    {
        public double GetNetSalary (EmployeeBase employee)
        {
            double grossSalary = employee.CalculateSalary();
            double tax = TaxCalculator.CalculateTax (grossSalary);

            return grossSalary - tax;
        }
    }
}
