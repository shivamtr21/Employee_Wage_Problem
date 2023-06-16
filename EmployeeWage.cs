using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwage
{
    public class EmployeeWage
    {

        
        public static void EmployeeAttendence()
        {
            int empHrs = 0;
            int empWage = 0;
            int Wage_Per_Hour = 20;

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;

            Random random = new Random();
            int result = random.Next(3);

            switch (result)
            {
                case IS_FULL_TIME:
                    
                        empHrs = 8;
                        break;

                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * Wage_Per_Hour;
            Console.WriteLine("Emp Wage :"+ empWage)
                



        }
    }
}
