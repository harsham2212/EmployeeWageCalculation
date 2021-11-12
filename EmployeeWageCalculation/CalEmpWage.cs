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
    }
}
