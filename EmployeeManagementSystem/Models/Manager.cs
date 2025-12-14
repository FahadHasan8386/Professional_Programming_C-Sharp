using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Interfaces;

namespace EmployeeManagementSystem.Models
{
    public class Manager : EmployeeBase ,IBonusEligible
    {
        public double BasicSalary { get; private set; }
        public double Bonus { get; private set; }
        public Manager(int id, string name, double basicSalary, double bonus) : base(id, name)
        {
            BasicSalary = basicSalary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BasicSalary  + Bonus;
        }
        public double CalculateBonus()
        {
            return Bonus;
        }

    }
}
