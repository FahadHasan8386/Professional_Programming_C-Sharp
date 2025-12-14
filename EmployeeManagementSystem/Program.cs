using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Service;

class Program
{
    static void Main()
    {
        SalaryService salaryService = new SalaryService();

        EmployeeBase manager = new Manager(1, "Fahad", 10000, 3000);

        EmployeeBase intern = new Intern(2, "Hasan");

        Console.WriteLine("Managet Net Salary : {salaryService.GetNetSalary(manage)}");
        Console.WriteLine("Ietrn Net Salary : {salaryService.GetNetSalary(intern)}");
    }
}