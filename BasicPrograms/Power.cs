using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Power
    {
        public static void PowerOfTwo()
        {
            Console.WriteLine("Enter number ");
            int maxPower;
            maxPower = Convert.ToInt32(Console.ReadLine());
            PrintTableOfTwo(maxPower);
        }
        private static void PrintTableOfTwo(int power)
        {
            Console.Write("[ ");
            for(int i= 1;i<=power;i++)
            {
                Console.WriteLine(Math.Pow(2, i)+" ");
            }
            Console.WriteLine("]");
        }
    }
}
