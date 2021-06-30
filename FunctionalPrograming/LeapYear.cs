using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograming
{
    class LeapYear
    {
        public static void ReadInput()
        {
            Console.WriteLine("enter the year:");
            int Year = int.Parse(Console.ReadLine());
            FindLeapYear(Year);
        }
        private static void FindLeapYear(int Year)
        {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            Console.ReadLine();
        }
    }
}
