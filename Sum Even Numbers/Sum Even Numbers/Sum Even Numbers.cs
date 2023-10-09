namespace Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            
            foreach(int i in num)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}