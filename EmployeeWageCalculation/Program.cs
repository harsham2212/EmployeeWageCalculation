﻿using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to EmployeeWage Computation Program on Master Branch");
            CalEmpWage Attendance = new CalEmpWage();
            Attendance.EmployeeCheck();
            CalEmpWage Wages = new CalEmpWage();
            Wages.EmpWage();
            CalEmpWage parttime = new CalEmpWage();
            parttime.EmployeeDailyWage();
            CalEmpWage Dailywage = new CalEmpWage();
            Dailywage.DailyEmployeeWage();
        }
    }
}