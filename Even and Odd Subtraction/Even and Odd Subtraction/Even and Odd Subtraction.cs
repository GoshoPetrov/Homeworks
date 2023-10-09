namespace Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            
            foreach(int n in num)
            {
                if(n % 2 == 0)
                {
                    sumEven += n;
                }
                else
                {
                    sumOdd += n;
                }
            }
            Console.WriteLine(sumEven - sumOdd);


        }
    }
}