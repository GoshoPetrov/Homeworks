using System.Globalization;

namespace Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                int leftSum = 0;
                int rightSum = 0;

                for(int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                for(int x = 0; x < i; x++)
                {
                    leftSum += arr[x];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");
        }
    }
}