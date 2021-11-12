using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    public class CalEmpWage
    {
        const int PRESENT = 1;
        public void EmployeeCheck()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        // Calculating Employee Wage


        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8;
        int totalSalary;

        public void EmpWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == 1)
            {
                this.totalSalary = WAGE_PR_HR * FULL_DAY_HOUR;
                Console.WriteLine("Employee is Present and Salary is: " + this.totalSalary);
            }
            else
                Console.WriteLine("Employee is Absent, So wage is not calculated");

        }
    }
}
