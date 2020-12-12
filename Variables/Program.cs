using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //! Intro to variables
            // string characterName = "John";
            // int characterAge;
            // characterAge = 35;
            // Console.WriteLine("There once was a man named " + characterName);
            // Console.WriteLine("He was " + characterAge + " years old");
            // characterName = "Mike";
            // Console.WriteLine("He really liked the name " + characterName);
            // Console.WriteLine("But didn't like being " + characterAge);

            //! Data types:
            // string phrase = "Learning C# is fun";
            // char grade = 'A';
            // int age = 26;
            // //? Can also use float or decimal...decimal is most accurate while float is least accurate
            // //? double is right in the middle
            // double gpa = 4.0;
            // bool isMale = true;

            //! Working with Strings:
            string phrase = "Pete's badass code \n" + "whats up";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            //? Returns true or false if the string contains the parameter that is given to the method.
            //todo Case sensitive
            Console.WriteLine(phrase.Contains("Pete"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Pete"));
            Console.WriteLine(phrase.IndexOf("badass"));
            Console.WriteLine(phrase.IndexOf("q"));
            Console.WriteLine(phrase.Substring(2));
            Console.WriteLine(phrase.Substring(phrase.IndexOf("badass"), "badass".Length).ToUpper());

            Console.ReadLine();
        }
    }
}
