namespace Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            //int price = 50;
            //int size = 2;
            //int[] bullets = { 11, 10, 5, 11, 10, 20 };
            //int[] locks = { 15, 13, 16 };
            //int intelligence = 1500;

            int bcount = 0;
            int barrel = size;
            Queue<int> l = new Queue<int>(locks);
            Stack<int> b = new Stack<int>(bullets);

            while (!(l.Count == 0 || b.Count == 0))
            {
                bcount++;
                int bl = b.Pop();
                int lo = l.Peek();

                if (bl <= lo)
                {
                    l.Dequeue();
                    Console.WriteLine("Bang!");
                } else
                {
                    Console.WriteLine("Ping!");
                }

                barrel--;
                if (barrel == 0)
                {
                    if (b.Count > 0)
                    {
                        barrel = size;
                        Console.WriteLine("Reloading!");
                    }
                }
            }

            if (l.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {l.Count}");
            } 
            else
            {
                Console.WriteLine($"{b.Count} bullets left. Earned ${intelligence - bcount * price}");

            }

        }
    }
}