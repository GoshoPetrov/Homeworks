namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> idk = new Stack<int>(clothes);

            int sum = 0;
            int count = 1;

            while (idk.Count != 0)
            {
                int current = idk.Pop();
                sum += current;
                if (sum <= capacity)
                {
                    continue;
                }
                else
                {
                    sum = current;
                    count++;
                }
               
            }

            Console.WriteLine(count);
        }
    }
}