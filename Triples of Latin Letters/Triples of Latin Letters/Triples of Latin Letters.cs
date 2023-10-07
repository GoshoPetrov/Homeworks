namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            nplet("", n);
        }

        static void nplet(string s, int n)
        {
            if (s.Length == n)
            {
                Console.WriteLine(s);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                char c = (char)('a' + i);
                nplet($"{s}{c}", n);
            }
        }
    }
}