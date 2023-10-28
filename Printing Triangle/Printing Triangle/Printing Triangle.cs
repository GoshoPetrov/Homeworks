namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTriangle(num);
        }

        static void PrintTriangle(int n)
        {
            for(int j = 0; j <= n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }

            for (int j = n - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }
    }
}