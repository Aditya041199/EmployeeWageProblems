using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmployeeWage.EmpWage("LNT", 20, 22, 25);
            EmployeeWage.EmpWage("TIPL", 20, 22, 25);
        }
    }
}