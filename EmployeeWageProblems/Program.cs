using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmpWageBuilderObject LNT = new EmpWageBuilderObject("LNT", 20, 2, 20);
            EmpWageBuilderObject TIPL = new EmpWageBuilderObject("TIPL", 20, 2, 20);
            LNT.ComputeEmpWage();
            Console.WriteLine(LNT.ToString());
            TIPL.ComputeEmpWage();
            Console.WriteLine(TIPL.ToString());
        }
    }
}