using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Handling numbers
            // Console.WriteLine(5 % 2);
            // Console.WriteLine(4 + 2 * 3);
            // Console.WriteLine((4 + 2) * 3); //? Use parenthesis to change order of operations
            // Console.WriteLine(5 / 2); //? Output will be an int 
            // Console.WriteLine(5.0 / 2); //? Output will be a decimal
            // Console.WriteLine(5 / 2.0); //? Output will be a decimal

            // //? Variables & Numbers
            // double myVar = 5.0;
            // //? Notice the difference here between the next two lines
            // Console.WriteLine(myVar++); //output = 5 --> the result is the value BEFORE incrementing
            // Console.WriteLine(++myVar); //output = 7 --> the result ist the value AFTER incrementing
            
            //? Methods
            // Console.WriteLine( Math.Abs(-3.9) ); //3.9
            // Console.WriteLine( Math.Pow(2, 2) ); //4
            // Console.WriteLine( Math.Max(1, 6)); //6
            // Console.WriteLine( Math.Min(1, 6)); //1
            // Console.WriteLine( Math.Round(1.4)); //1
            // Console.WriteLine( Math.Round(1.6)); //2

            //! Getting user input
            // doesn't go to a new line like WriteLine
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Hello, " + name + "! How does it feel to be " + age + '?');
            string response = Console.ReadLine();
            Console.WriteLine("Whatever you say " + name);
            Console.WriteLine("I mean, what does this even mean dude?\n" + response);


            Console.ReadLine();
        }
    }
}
