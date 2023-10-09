namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while(num.Length > 1)
            {
                int[] n2 = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    int e = num[i] + num[i + 1];
                    n2[i] = e;
                }

                num = n2;
            }

            Console.WriteLine(num[0]);
        }
    }
}