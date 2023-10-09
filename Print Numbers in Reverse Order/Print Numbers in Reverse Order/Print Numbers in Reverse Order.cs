namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i =0; i < n; i++)
            {
                Console.Write($"{arr[n - 1 - i]} ");
            }


        }
    }
}