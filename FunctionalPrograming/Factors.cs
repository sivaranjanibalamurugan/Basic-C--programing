using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    class Factors
    {
        public static void ReadInput()
        {
            Console.WriteLine("enter number to find factors:");
            int num = Convert.ToInt32(Console.ReadLine());//conversion
            FindFactors(num);
        }
        private static void FindFactors(int num)
        {
            //condition to find the factors 
            while (num % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                num /= 2;
            }

            //checking for a odd number
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                // While i divides num, print i and divide num
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }

            // This condition when num is prime and greater than 2
           
            if (num > 2)
                Console.WriteLine(num);
        }

    }

}

