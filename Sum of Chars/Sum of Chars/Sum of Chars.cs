namespace Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                char n = char.Parse(Console.ReadLine());
                sum += (int)n;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}