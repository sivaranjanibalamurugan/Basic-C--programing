using System;

namespace FunctionalPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Basic Programing ");
            Console.WriteLine("1) LeapYear(Year)");
            Console.WriteLine("2) Factors(num)");
            Console.WriteLine("3) Alphabet");
           Console.WriteLine("4) GreatestOfThree");
            Console.WriteLine("5) exit");
            Console.WriteLine("enter the option");
            switch (Console.ReadLine())
            {
                case "1":
                    LeapYear.ReadInput();
                    break;
                
                case "2":
                    Factors.ReadInput();
                    break;
                case "3":
                    Alphabet.ReadInput();
                    break;
               case "4":
                    GreatestOfThree.ReadInput();
                    break;
                case "5":

                    break;
                default:
                    Console.WriteLine("enter the right option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
