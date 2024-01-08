namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { 
                {1, 2, 3 }, 
                {4, 5, 6 }, 
                {7, 8, 9 } 
            };

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for(int j = 0; j < arr.GetLength(1) - 1; i++)
                {
                    Console.Write("0", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}