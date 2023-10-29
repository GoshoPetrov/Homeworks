namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(a), int.Parse(b)));
            }

            if (type == "char")
            {
                Console.WriteLine(GetMax(a[0], b[0]));
            }

            if (type == "string")
            {
                Console.WriteLine(GetMax(a, b));
            }

        }

        
        static int GetMax(int a, int b)
        {
            if (a > b) return a;
            return b;
        }

        static char GetMax(char a, char b)
        {
            if (a > b) return a;
            return b;
        }

        static string GetMax(string a, string b)
        {
            if (string.Compare(a, b) > 0) return a;
            return b;
        }

    }
}