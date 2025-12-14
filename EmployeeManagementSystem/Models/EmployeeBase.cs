using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public abstract class EmployeeBase
    {
        public string Name { get; protected set; }
        public int Id { get; private set; }

        protected EmployeeBase(int id , string name)
        {
            Id = id;
            Name = name;
        }
        public abstract double CalculateSalary();
    }
}
