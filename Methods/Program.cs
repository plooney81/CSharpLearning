using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // SayHi();
            // SayHi("Pete", 27);

            Console.WriteLine(CubedNumber(5));
            string[] theArray = {"Pete", "David", "Shan", "Beth"};
            string[] theRetunArray = friends(theArray);
            foreach (string name in theRetunArray)
            {
                Console.Write(name + " ");
            }

            Console.ReadLine();
        }
        // void is the return type...meaning our method wont return anything.
        static void SayHi(string User = "Default", int age = 26) 
        {
            Console.WriteLine($"Hello {User}, you are {age}");
        }

        //! Demonstration of the return statement
        static int CubedNumber(int number)
        {
            return number * number * number;
        }

        static string[] friends(string[] friendsArray)
        {
            friendsArray[0] = "Chandler";
            return friendsArray;
        }

    }
}
