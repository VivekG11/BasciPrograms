using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            Console.WriteLine("Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient of "+dividend+" is :"+quotient);
            Console.WriteLine("Remainder of "+quotient+ " is :"+remainder);
        }
    }
}
