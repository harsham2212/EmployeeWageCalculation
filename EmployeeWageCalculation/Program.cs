using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
