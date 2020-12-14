using System;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example = {1, 2, 3, 4, 5};
            int[] answer = TwoNumberSum(example, 9);
            foreach (int number in answer)
            {
                Console.Write(number);
            }
        }

        static int[] TwoNumberSum(int[] array, int targetSum)
        {
            int left = 0;
            int right = array.Length - 1;
            int[] returnArray = new int[2];
            while (left < right)
            {
                int sum = array[right] + array[left];
                
                if(sum == targetSum)
                {
                    returnArray[0] = array[right];
                    returnArray[1] = array[left];
                    return returnArray;
                }else if(sum > targetSum)
                {
                    right--;
                }else
                {
                    left++;
                }
            }
            return returnArray;
        }
    }
}
