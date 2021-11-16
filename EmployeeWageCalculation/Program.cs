using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program");
            CalEmpWage Attendance = new CalEmpWage();
            Attendance.EmployeeCheck();
        }
    }
}
