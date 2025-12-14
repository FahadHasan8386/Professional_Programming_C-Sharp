using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public sealed class Intern : EmployeeBase
    {
        private const double FixedStipend = 5000;
        public Intern (int  id ,string name) : base (id , name) 
        {

        }

        public override double CalculateSalary()
        {
            return FixedStipend;
        }
    }
}
