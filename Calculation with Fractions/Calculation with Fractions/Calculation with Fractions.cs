using Fractions;

namespace Calculation_with_Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Fraction f1 = p(input[0]);
            Fraction f2 = p(input[2]);

            if (input[1] == "+")
            {
                Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
            } else
            {
                Console.WriteLine($"{f1} - {f2} = {f1 - f2}");

            }
        }

        static Fraction p(string expession)
        {
            string[] f = expession.Split('/');

            Fraction f1 = int.Parse(f[0]);
            Fraction f2 = int.Parse(f[1]);

            return f1 / f2;
        }
    }
}
