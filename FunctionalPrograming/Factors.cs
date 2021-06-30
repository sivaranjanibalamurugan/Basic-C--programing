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
            int num = Convert.ToInt32(Console.ReadLine());
            FindFactors(num);
        }
        private static void FindFactors(int num)
        {
            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num /= 2;
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                // While i divides n, print i and divide n
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }

            // This condition is to handle the case whien
            // n is a prime number greater than 2
            if (num > 2)
                Console.WriteLine(num);
        }

    }

}

