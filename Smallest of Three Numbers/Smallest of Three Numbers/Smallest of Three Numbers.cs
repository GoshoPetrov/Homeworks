namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNum(numOne, numTwo, numThree));
        }

        static int SmallestNum(int numOne, int numTwo, int numThree)
        {
            int smallestNum = 0;
            if(numOne < numTwo && numOne < numThree)
            {
                smallestNum = numOne;
            }
            else if (numTwo < numOne && numTwo < numThree)
            {
                smallestNum = numTwo;
            }
            else if (numThree < numOne && numThree < numTwo)
            {
                smallestNum = numThree;
            }
            else
            {
                smallestNum = numOne;
            }

            return smallestNum;
        }
    }
}