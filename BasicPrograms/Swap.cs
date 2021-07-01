using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Swap
    {
        public static void SwappingValues()
        {
            /*...............................................
             * Case 1: Solving using temp variable
             * ........................................*/
            int temp = 0;
            Console.WriteLine("Enter values to be swapped :");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values before swapping: "+first+" "+second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("Values after swapping : "+ first+" "+second );
        }
        /*....................................................
         * case 2: Solving using two variables
         * .....................................................*/
        public static void SwappingVariables()
        {
            Console.WriteLine("Enter the values :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("values before swapping :"+a+" "+b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("values after swapping are : "+a+" "+b);
        }
    }
}
