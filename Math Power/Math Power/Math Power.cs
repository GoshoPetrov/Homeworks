namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(num, power));
        }
        static double MathPower(double num, double power)
        {
            double result = 0;

            result = Math.Pow(num, power);

            return result;
        }
    }
}