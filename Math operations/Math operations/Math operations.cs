namespace Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double numTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(Calculate(numOne, type, numTwo)));


        }

        static double Calculate(double numOne, string type, double numTwo)
        {
            double result = 0;

            if(type == "/")
            {
                result = numOne / numTwo;
            }
            else if(type == "*")
            {
                result = numOne * numTwo;
            }
            else if(type == "+")
            {
                result = numOne + numTwo;
            }
            else if(type == "-")
            {
                result = numOne - numTwo;
            }

            return result;
        }
    }
}