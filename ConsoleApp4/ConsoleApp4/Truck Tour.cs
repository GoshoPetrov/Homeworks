namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] fuel = new int[n];
            int[] distance = new int[n];

            for(int i = 0; i< n; i++)
            {
                int[] commnd = Console.ReadLine().Split().Select(int.Parse).ToArray();
                fuel[i] = commnd[0];
                distance[i] = commnd[1];
            }

            for (int start=0; start < n; start++)
            {

                int tankFuel = 0;
                for (int j=start; j<start + n; j++)
                {
                    tankFuel += fuel[j % n];
                    tankFuel -= distance[j % n];

                    if (tankFuel < 0) break;
                }

                if (tankFuel > 0)
                {
                    Console.WriteLine(start);
                    break;
                }

            }
        }
    }
}