using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program on Master Branch \n ");

            CalEmpWage Attendance = new CalEmpWage();
            Attendance.EmployeeCheck();
            CalEmpWage Wages = new CalEmpWage();
            Wages.EmpWage();
            CalEmpWage parttime = new CalEmpWage();
            parttime.EmployeeDailyWage();
            CalEmpWage Dailywage = new CalEmpWage();
            Dailywage.DailyEmployeeWage();
            CalEmpWage Monthly = new CalEmpWage();
            Monthly.MonthlyEmpWage();
            CalEmpWage Hours = new CalEmpWage();
            Hours.MonthlyEmployeeWage();
        }
    }
}