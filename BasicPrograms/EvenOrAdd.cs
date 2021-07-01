using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class EvenOrAdd
    {
        public static void FindEvenOrOdd()
        {
            Console.WriteLine("Enter a number to find even or odd :");
            int num = Convert.ToInt32(Console.ReadLine());
            /*.......................................................
             * if he entered num is divisible by two then it is  even else odd
             * ....................................................*/
            if(num%2==0)
            {
                Console.WriteLine("Entered number is Even Number");
            }
            else
            {
                Console.WriteLine("Entered number is Odd Number");
            }
        }
    }
}
