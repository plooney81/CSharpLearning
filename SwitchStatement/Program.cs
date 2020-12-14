using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input a Movie Genre to see the top viewed movie for that genre: ");
            string genre = Console.ReadLine();
      

            switch (genre)
            {
            case "Drama":
                Console.WriteLine("Citizen Kane");
                break;
            case "Comedy":
                Console.WriteLine("Duck Soup");
                break;
            case "Adventure":
                Console.WriteLine("Kink Kong");
                break;
            case "Horror":
                Console.WriteLine("Psycho");
                break;
            case "Science Fiction":
                Console.WriteLine("2001: A Space Odyssey");
                break;
            default:
                Console.WriteLine("No move found");
                break;
            }
        }
    }
}
