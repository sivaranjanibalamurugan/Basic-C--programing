using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    class Alphabet
    {
       public static void ReadInput()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());//converting to char
            FindAlbhabet(ch);
        }

            private static void FindAlbhabet(char ch)
        { 

            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) //condition for consonant
            {
                Console.WriteLine(ch + " is Consonant.");
            }

            Console.ReadLine();
            }
    }
}

