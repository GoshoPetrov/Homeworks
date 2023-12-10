namespace Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> c = new Queue<int>(cups);
            Stack<int> b = new Stack<int>(bottles);

            int wasted = 0;
            int cc = c.Dequeue();
            while (true)
            {
                int bo = b.Pop();
                cc -= bo;

                if (cc <= 0)
                {
                    wasted += -1 * cc;
                    if (c.Count == 0)
                    {
                        break;
                    }
                    cc = c.Dequeue();
                }

                if (b.Count == 0)
                {
                    break;
                }
            }

            if (b.Count > 0)
            {
                Console.Write($"Bottles:");
                while (b.Count > 0)
                {
                    Console.Write($" {b.Pop()}");
                }
                Console.WriteLine($"");
            }
            else
            {
                Console.Write($"Cups:");
                Console.Write($" {cc}");
                while (c.Count > 0)
                {
                    Console.Write($" {c.Dequeue()}");
                }
                Console.WriteLine($"");

            }


            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}