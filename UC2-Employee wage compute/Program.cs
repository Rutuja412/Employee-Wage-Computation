using System;

namespace UC2_Employee_wage_compute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constatnts
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            //computation
            int empCheck=random.Next(0,2);
            if (empCheck==IS_FULL_TIME)
            {
            empHrs= 8;
            }
            else
            {
                empHrs= 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage=" +empWage);
        }
    }
}
