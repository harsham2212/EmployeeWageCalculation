using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program");
            CalEmpWage refactor = new CalEmpWage();
            refactor.EmployeeCheck();
        }
    }
}