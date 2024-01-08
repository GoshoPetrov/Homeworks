namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] value = new int[size[0], size[1]];

            for(int i = 0; i < size[0]; i++)
            {
                int[] cols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int j = 0; j < cols.Length; j++)
                {
                    value[i, j] = cols[j];
                }
            }

            int sum = 0;

            foreach(int element in value)
            {
                sum += element;
            }

            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);

        }
    }
}