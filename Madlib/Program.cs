using System;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity, story; // can declare multiple variables of the same type on the same line by adding commas in between

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            story = $"Roses are {color}\n{pluralNoun} are blue\nI Love {celebrity}";
            Console.WriteLine(story);

            Console.ReadLine();
        }
    }
}
