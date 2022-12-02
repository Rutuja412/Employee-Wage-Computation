using System;

namespace UC_6Employee_Wage
{
     class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR =20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOURS_IN_MONTH = 10;

        static void Main(string[] args)
        {
            int empHrs = 0,totalempHrs=0, totalWorkingDays = 0;
            while(totalempHrs<=MAX_HOURS_IN_MONTH && totalWorkingDays<NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random= new Random();
                int empCheck=random.Next(0,3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs=4; 
                        break;
                        case IS_FULL_TIME:
                        empHrs=8;
                        break;
                        default: empHrs=0;
                        break;

                }
                totalempHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage; "+totalEmpWage);
        }
    }
}
