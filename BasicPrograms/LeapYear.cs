using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        public static void FindLeapYear()
        {
            int year;
            Console.WriteLine("Enter a year :");
            year = Convert.ToInt32(Console.ReadLine());
            //check whether the year entered is a valid four digit or not
            if(year > 1000 && year < 9999)
            {
                //Following is the condition to check Whether the entered year is lesp year or not
                if(((year % 4 == 0) && (year % 100)!=0) ||(year % 400 ==0))
                {
                    Console.WriteLine("Entered year is a leap year");

                }
                else
                {
                    Console.WriteLine("Entered year is a leap year");
                }
                        
            }
            //If the entered year in not a 4 digit number control executes the below statement
            else
            {
                Console.WriteLine("Enter a Valid Year");
            }
            Console.Read();
        }
    }
}
