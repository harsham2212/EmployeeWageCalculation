using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation

        // UseCase-1 : Checking randomly Employee is present or absent
{
    public class CalEmpWage
    {
        public const int WAGE_PR_HR = 20, FULL_DAY_HOUR = 8, HALF_DAY_HOUR = 4, IS_PRESENT = 1, IS_ABSENT = 2;
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, WAGE_PER_HR = 20, FULL_WORKING_HRS = 8, PART_WORKING_HRS = 4;
        public const int PRESENT = 1, HALF_DAY = 2, TOTAL_DAYS = 20;
        int totalSalary, empHr;
        int totalEmpWage, empHrs;
        int TOTAL_HOUR = 0;
        // const int PRESENT = 1;
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


        // UseCase -3 : Calculating Part-time and Daily wage


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

        // UseCase-4 : Using SwitchCase

        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    this.empHrs = FULL_WORKING_HRS;
                    Console.WriteLine("Employee worked Full time");
                    break;
                case IS_PART_TIME:
                    this.empHrs = PART_WORKING_HRS;
                    Console.WriteLine("Employee worked Half time");
                    break;
                default:
                    this.empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            Console.WriteLine(this.totalEmpWage = this.empHrs * WAGE_PER_HR);
        }

        // UseCase-5 : Calculating Monthly Wage of Employee

        public void MonthlyEmpWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            for (int i = 0; i < TOTAL_DAYS; i++)
                switch (empCheck)
                {
                    case PRESENT:
                        this.empHr += FULL_DAY_HOUR;
                        break;
                    case HALF_DAY:
                        this.empHr += HALF_DAY_HOUR;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent for the Day");
                        break;
                }
            this.totalSalary = WAGE_PR_HR * empHr;
            Console.WriteLine("Here is the Monthly Salary of Emp." + this.totalSalary);
        }

    }
    }
