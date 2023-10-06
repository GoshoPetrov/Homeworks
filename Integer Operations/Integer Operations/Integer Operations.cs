namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numOne = decimal.Parse(Console.ReadLine());
            decimal numTwo = decimal.Parse(Console.ReadLine());
            decimal numThree = decimal.Parse(Console.ReadLine());
            decimal numFour = decimal.Parse(Console.ReadLine());

            decimal sum = numOne + numTwo;
            decimal sumDivide = sum / numThree;
            decimal sumAll = sumDivide * numFour;

            Console.WriteLine(sumAll);
            
        }
    }
}