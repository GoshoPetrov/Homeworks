namespace Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The number {num} is {Sign(num)}.");
        }

        static string Sign(int num)
        {
            if (num > 0)
            {
                return "positive";
            }
            else if (num < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
    }
}