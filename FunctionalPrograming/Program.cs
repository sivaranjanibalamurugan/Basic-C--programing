using System;

namespace FunctionalPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Basic Programing ");
            Console.WriteLine("1) LeapYear(Year)");
            Console.WriteLine("2) exit");
            Console.WriteLine("enter the option");
            switch (Console.ReadLine())
            {
                case "1":
                    LeapYear.ReadInput();
                    break;
                
                case "2":

                    break;
                default:
                    Console.WriteLine("enter the right option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
