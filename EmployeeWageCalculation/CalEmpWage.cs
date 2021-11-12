using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation

        // UseCase-1 : Checking randomly Employee is present or absent
{
    public class CalEmpWage
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, IS_PRESENT = 1, IS_ABSENT = 2;
        int totalSalary, TOTAL_HOUR = 0;
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

        // UseCase-2 : Calculating Employee Wage

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


        // Calculating Part-time and Daily wage

        
        public void EmployeeDailyWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == 1)
            {
                this.TOTAL_HOUR = FULL_DAY_HOUR;
            }
            if (empCheck == 2)
            {
                this.TOTAL_HOUR = HALF_DAY_HOUR;
            }
            else
                Console.WriteLine("Employee is Absent");

            this.totalSalary = WAGE_PR_HR * TOTAL_HOUR;
            Console.WriteLine("Employee Salary is: " + this.totalSalary);
        }

        //
    }
}
