using System;

namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // string ageAsString = "102";
            // string nameAsString = "Granny";

            // bool outcome = Int32.TryParse(ageAsString, out int ageAsInt);
            // Console.WriteLine(ageAsInt + " " + outcome);

            // bool outcome2 = Int32.TryParse(nameAsString, out int nameAsInt);
            // Console.WriteLine(nameAsInt + " " + outcome2);

            string whisperText = Whisper("YELLING", out bool outcome);
            Console.WriteLine(whisperText + " " + outcome);
        }

        static string Whisper(string phrase, out bool didWhisper)
        {
            didWhisper = true;
            return phrase.ToLower();
        }
    }
}
