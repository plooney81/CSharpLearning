using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            NamePets("Mackenzie", "Bud");
            NamePets("Mackenzie", "Bud", "Peach");
            NamePets();
        }

        static void NamePets(string nameOne, string nameTwo)
        {
            string output = $"Your pets {nameOne} and {nameTwo} will be joining your voyage across space!";
            Console.WriteLine(output);
        }
        static void NamePets(string nameOne, string nameTwo, string nameThree)
        {
            string output = $"Your pets {nameOne}, {nameTwo}, and {nameThree} will be joining your voyage across space!";
            Console.WriteLine(output);
        }
        static void NamePets()
        {
            string output = $"Aw, you have no spacefaring pets";
            Console.WriteLine(output);
        }
    }
}
