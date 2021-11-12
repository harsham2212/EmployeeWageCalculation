using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program on Master Branch");
            CalEmpWage attendance = new CalEmpWage();
            attendance.EmployeeCheck();
        }
    }
}
