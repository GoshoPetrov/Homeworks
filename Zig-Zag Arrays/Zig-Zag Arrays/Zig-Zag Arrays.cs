using System.Linq;

namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine() // string
                    .Split() // string[]
                    .Select(int.Parse)
                    .ToArray(); // int[]

                if (i % 2 == 0)
                {
                    arrOne[i] = input[0];
                    arrTwo[i] = input[1];
                }
                else
                {

                    arrOne[i] = input[1];
                    arrTwo[i] = input[0];
                }


            }

            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));

            


        }
    }
}