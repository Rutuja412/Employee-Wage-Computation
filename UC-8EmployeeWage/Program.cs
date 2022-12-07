using System;

namespace UC_8EmployeeWage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string compony,int empRatePerHour,int numOfWorkingDays,int maxHourPerMonth)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computations
            while (totalEmpHrs<=maxHourPerMonth && totalWorkingDays < numOfWorkingDays ) 
            {
            totalWorkingDays++;
                Random random= new Random();
                int empCheck=random.Next(0,3);
                switch (empCheck) 
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                        case IS_FULL_TIME:
                        empHrs=8;
                        break;
                        default: 
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:"+totalWorkingDays+"Emp Hrs :"+ empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Compony :" + compony + "is:" + totalEmpWage);
            return totalEmpWage;
            
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
