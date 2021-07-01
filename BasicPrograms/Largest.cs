using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Largest
    {
        public static void LargestOfThree()
        {
            /*..................................................
             * initialize three variables to perform comaprision
             * ..................................................*/
            Console.WriteLine("Enter three values :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            /*.........................................................
             * Use if condition to check which number is largest
             * ...................................................*/
            if((a>b) && (a>c))
            {
                Console.WriteLine(a+" is the largest number");
            }
            else if((b>a) && (b>c))
            {
                Console.WriteLine(b + " is the largest number");
            }
            else
            {
                Console.WriteLine(c + " is the largest number");
            }
        }
    }
}
