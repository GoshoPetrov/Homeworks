namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dolars = pounds * 1.31f;
            Console.WriteLine($"{dolars:F03}");

        }
    }
}