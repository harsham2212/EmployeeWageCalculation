using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program");
            Console.WriteLine("Enter the Company Name: ");
            string company = Console.ReadLine();
            Console.WriteLine("Enter the Rate per Hour: ");
            int empRatePrHr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Working Days: ");
            int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Max Hour Per Month: ");
            int maxHourPrMonth = Convert.ToInt32(Console.ReadLine());

            CalEmpWage empWage = new CalEmpWage();
            empWage.ComputeEmployeeWage(company, empRatePrHr, numOfWorkingDays, maxHourPrMonth);
=======
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
>>>>>>> UC6-Hours_Reached
        }
    }
}