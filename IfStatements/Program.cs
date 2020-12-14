using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if(isMale)
            {
                Console.WriteLine("You are a short male");
            } else if(isTall)
            {
                Console.WriteLine("You are a tall not male");
            } else 
            { 
                Console.WriteLine("You are not male and short");
            }

            Console.ReadLine();
        }
    }
}
