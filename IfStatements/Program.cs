using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool isMale = true;
            // bool isTall = true;
            // if (isMale && isTall)
            // {
            //     Console.WriteLine("You are a tall male");
            // } else if(isMale)
            // {
            //     Console.WriteLine("You are a short male");
            // } else if(isTall)
            // {
            //     Console.WriteLine("You are a tall not male");
            // } else 
            // { 
            //     Console.WriteLine("You are not male and short");
            // }
            Console.WriteLine(MaxMethod(1, 2, 3));

            Console.ReadLine();
        }
        static int MaxMethod(int num1, int num2, int num3)
        {
            // int result;

            // if(num1 > num2)
            // {
            //     result = num1;
            // }else
            // {
            //     result = num2;
            // }

            // return result;

            //Alternatively we can use a ternary operator that does the same thing in one line
            // return num1 > num2 ? num1 : num2;
            
            int[] options = {num1, num2, num3};
            int result = 0;
            for (int i = 0; i < options.Length; i++)
            {
                if(options[i] > result)
                {
                    result = options[i];
                }
                
            }
            return result;
        }
    }
}
