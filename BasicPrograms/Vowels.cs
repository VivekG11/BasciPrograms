using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class Vowels
    {
        public static void FindVowels()
        {
            char ch;
            Console.WriteLine("Enter the Alphabet :");
            ch = Convert.ToChar(Console.ReadLine());
            /*..............................................................
             * Check the input alphabet with vowels using or condition
             * .........................................................*/
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered Alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("Entered Alphabet is a Consonant");
            }
        }
    }
}
