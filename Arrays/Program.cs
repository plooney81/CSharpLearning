using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Creates an array of integers name luckyNumbers and initializes that array with some different integers.
            int [] luckyNumbers = {4, 12, 20, 28, 36 };

            //! Creates an empty array of strings, but we need to tell C# how big we want to make the empty array.
            //! We have to give it a length. Here we tell it that the array can only five.
            string [] friends = new string[5];
            // Console.WriteLine( luckyNumbers[0]);
            friends[0] = "Jim";
            friends[1] = "Pam";
            friends[2] = "Ryan";
            // friends[3] = "Michael";
            foreach(string friend in friends)
            {
                Console.WriteLine(friend);
            }

            // luckyNumbers[0] = 12;
            // Console.WriteLine( luckyNumbers[0]);
            // foreach (int number in luckyNumbers)
            // {
            //     Console.WriteLine(number);
            // }
        }
    }
}
