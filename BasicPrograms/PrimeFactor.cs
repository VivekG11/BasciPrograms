using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactor
    {
        public static void FindPrimeFactor()
        {
            Console.WriteLine("Enter a value to find Prime factors ");
            int num = Convert.ToInt32(Console.ReadLine());
                for (int i =2; i*i<num ; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i+" ");
                }
                else
                {
                    Console.WriteLine("Entered Number is a Prime Number, so there won't be prime factors");
                    break;
                }
            }
        }
       
    }
}
