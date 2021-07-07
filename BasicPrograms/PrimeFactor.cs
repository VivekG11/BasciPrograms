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
            while(num % 2 == 0)
            {
                Console.Write(2 + " " );
                num = num / 2;
            }
            for (int i =3; i*i<=num ; i+=2)
            {
                while(num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if(num>2)
            {
                Console.WriteLine(num);
            }
           
        }
       
    }
}
