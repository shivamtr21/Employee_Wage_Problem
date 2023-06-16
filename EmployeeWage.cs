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
            int IS_PART_TTIME = 2;

            int Max_Days = 20;
            int Max_Hours = 100;
            int Wage_Per_hrs = 20;

            int EmpHrs = 0;
            int Total_wage = 0;

            int Total_work_Hour = 0;
            int day = 1;

            while(day <= Max_Days && Total_work_Hour <= Max_Hours)
            {
                Random random = new Random();
                int result = random.Next(3);

                switch (result)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;


                    case IS_PART_TTIME:
                        EmpHrs = 4;
                        break;


                    default:
                        EmpHrs = 0;
                        break;
                }
                day++;

                Total_work_Hour = (Total_work_Hour + EmpHrs);
                Total_wage = (Total_work_Hour * Wage_Per_hrs);
            }
            Console.WriteLine("Total working hour in a month " + Total_work_Hour);
            Console.WriteLine("Total salary for a month " + Total_wage);




        }
    }
}
