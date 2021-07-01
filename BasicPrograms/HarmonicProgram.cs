using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class HarmonicProgram
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(int i =1; i <= num; i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine("The Harmonic value is :"+ sum );
        }
    }
}
