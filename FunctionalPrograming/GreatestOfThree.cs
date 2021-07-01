using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace FunctionalPrograming
{
    class GreatestOfThree
    {
        public static void ReadInput()
        {
            int num1;
            int num2;
            int num3;
            //initializing local variable 
            Console.WriteLine("Find the largest of three numbers:\n");
            Console.WriteLine("Input the num1 :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the  num2 :");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the num3 :");
            num3 = int.Parse(Console.ReadLine());
            FindGreatestOfThree(num1 , num2 , num3);
        }
        private static void FindGreatestOfThree(int num1,int num2, int num3)
            
        {
            //checking if num1 is greater
         if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The  greatest number is:" +num1);
                }
                //checking if num2 is greater
                else if (num2 > num3)
                {
                    Console.WriteLine("The  greatest number is:" +num2);
                }
                //finding num3 is greatest 
                else
                {
                    Console.WriteLine("The  greatest number is:" +num3);
                }

            }
        }
    }
}

