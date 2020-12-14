using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a password: ");
            string password = Console.ReadLine();
            int passwordScore = 0;

            string upperCasePattern = @"[A-Z]";
            string lowerCasePattern = @"[a-z]";
            string digitPattern = @"\d{1}";
            string specialCharacterPattern = @"[^A-Za-z0-9]"; //Negative match

            if(password.Length >= 8){
            passwordScore++;
            }
            if(new Regex(upperCasePattern).IsMatch(password))
            {
            passwordScore++;
            }
            if(new Regex(lowerCasePattern).IsMatch(password))
            {
            passwordScore++;
            }
            if(new Regex(digitPattern).IsMatch(password))
            {
            passwordScore++;
            }
            if(new Regex(specialCharacterPattern).IsMatch(password))
            {
            passwordScore++;
            }
            string displayText;
            switch(passwordScore)
            {
            case 5:
                displayText = "Password is extremely strong";
                break;
            case 4:
                displayText = "Password is extremely strong";
                break;
            case 3:
                displayText = "Password is strong";
                break;
            case 2:
                displayText = "Password is medium";
                break;
            case 1:
                displayText = "Password is weak";
                break;
            default:
                displayText = "Password is terrible";
                break;
            }

            Console.WriteLine("{0} you scored {1} {2}", displayText, passwordScore, (passwordScore > 1 ? "Points": "Point"));
        }
    }
}
