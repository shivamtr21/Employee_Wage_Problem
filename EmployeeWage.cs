﻿using System;
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
            Random random = new Random();

            int result = random.Next(2);

            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }

            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
