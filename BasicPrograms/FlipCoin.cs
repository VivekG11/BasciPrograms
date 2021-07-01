using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class FlipCoin
    {
        public static void CoinFcaePercentage()
        {
            int num,head = 0, tail = 0;
            Console.WriteLine("Enter a number to find number of times to flip a coin : ");
            num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i =0; i < num; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5)
                {
                    tail++;
                }
                else 
                {
                    head++;
                }
            }
            Console.WriteLine("Total Number of tails = "+tail);
            Console.WriteLine("Total Number of heads = " + head);
            double tailPercentage = (double) tail / num * 100;
            double headPercentage = 100 - tailPercentage;
            Console.WriteLine("The percenatge of tails is : "+tailPercentage);
            Console.WriteLine("The percenatge of heads is : " + headPercentage);
        }
    }
}
