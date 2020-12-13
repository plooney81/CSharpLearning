//! Program propts the user to enter numbers, it will then add the numbers together and the output the result
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App");
            //? Converting string to numbers --> User input will always initially be a string
            // int num = Convert.ToInt32("45");
            
            // Console.Write("Enter a number: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter another number: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("The sum of the two numbers is " + (num1 + num2));
            // Console.ReadLine();

            //? Try Catch Logic to let the user know they entered a non number type
            //! In the above logic, if we tried to input an integer as the user, the program wouldn't 
            //! print anything out...because we converting to int32 and not double, float or decimal.
            try
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The sum of the two numbers is " + (num1 + num2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
