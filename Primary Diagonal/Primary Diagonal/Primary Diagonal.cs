namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] value = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for(int j = 0; j < size; j++)
                {
                    value[i, j] = col[j];
                }
            }

            int diagonal = 0;
            for (int i = 0; i < size; i++)
            {
                diagonal += value[i, i];
            }

            Console.WriteLine(diagonal);

        }

        static void Main2()
        {
            int size = int.Parse(Console.ReadLine());

            //int[,] value = new int[size, size];

            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        sum += col[j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}