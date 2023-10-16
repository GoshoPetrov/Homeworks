namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCount = 0;
            int bestN = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];

                int count = 1;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] != n)
                    {
                        break;
                    }

                    count++;
                }

                if (bestCount < count)
                {
                    bestCount = count;
                    bestN = n;
                }
                
            }

            for (int i=0; i<bestCount; i++)
            {
                Console.Write($"{bestN} ");
            }

        }
    }
}