namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            CharsBetween(start, end);
        }

        static void CharsBetween(char start, char end)
        {
            int startChar = Math.Min(start, end);
            int endChar = Math.

            for(int i = start + 1; i < end; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}