namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());

            

            for(int i = numStart; i <= numEnd;i++)
            {
                char x = (char)i;
                Console.Write($"{x} ");

            }
        }
    }
}