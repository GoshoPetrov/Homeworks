namespace Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                if (player1.Count == 0)
                {
                    int sum = 0;
                    foreach (int n in player2) sum += n;
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    return;
                }

                if (player2.Count == 0)
                {
                    int sum = 0;
                    foreach (int n in player1) sum += n;
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    return;
                }

                Play(player1, player2);

            }

        }

        private static void Play(List<int> player1, List<int> player2)
        {
            int player1top = player1[0];
            int player2top = player2[0];

            player1.RemoveAt(0);
            player2.RemoveAt(0);

            if (player1top == player2top)
            {

            }
            else if (player1top > player2top)
            {
                player1.Add(player1top);
                player1.Add(player2top);
            }
            else if (player1top < player2top)
            {
                player2.Add(player2top);
                player2.Add(player1top);
            }
        }
    }
}