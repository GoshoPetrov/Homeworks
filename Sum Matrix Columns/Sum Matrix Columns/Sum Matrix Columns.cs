namespace Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] value = new int[size[0], size[1]];

            for (int i = 0; i < value.GetLength(0); i++)
            {
                int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < value.GetLength(1); j++)
                {
                    value[i, j] = cols[j];
                }

            }

            for (int i = 0; i < value.GetLength(1); i++)
            {

                int sum = 0;

                for (int j = 0; j < value.GetLength(0); j++)
                {
                    sum += value[j, i];
                }


            }

        }

        static void Main2()
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] value = new int[size[0], size[1]];

            int[] sum = new int[size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < size[1]; j++)
                {
                    value[i, j] = cols[j];
                }

                for (int n = 0; n < size[1]; n++)
                {
                    sum[n] += value[i, n];
                }
            }

            Console.WriteLine(string.Join("\n", sum));

        }
    }
}