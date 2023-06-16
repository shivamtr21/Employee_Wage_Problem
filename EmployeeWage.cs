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
             
            int IS_FULL_TIME = 1;
            int empHrs =0;
            int empWage = 0;

            int Wage_Per_Hour = 20;


            Random random = new Random();

            int result = random.Next(2);

            if (result == IS_FULL_TIME)
            {
                empHrs = 8;
                 
            }

            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            empWage = (empHrs * Wage_Per_Hour);

            Console.WriteLine("Emp Wage : " empWage);

                



        }
    }
}
