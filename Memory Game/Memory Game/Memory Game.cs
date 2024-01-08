namespace Memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim().Split().ToList();

            List<string> twinTowers = new List<string>(input);

            int moves = 0;

            bool flag = true;

            int x = 0;
            int y = 0; 

            while (true)
            {
                
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    if (input.Count <= 0)
                    {
                    }
                    else
                    {
                        flag = false;
                    }
                    break;
                }

                if (int.Parse(command[0]) < int.Parse(command[1]))
                {
                    x = int.Parse(command[0]);
                    y = int.Parse(command[1]);
                }
                else
                {
                    x = int.Parse(command[1]);
                    y = int.Parse(command[0]);
                }

                if (input.Count <= 0)
                {
                    continue;
                }

                moves++;

                if (IfplayerIsCheating(x, y, input, moves))
                {
                    
                    if (input[x] == input[y])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[x]}!");
                        //input.RemoveAt(x);
                        //input.RemoveAt(y - 1);

                        input.RemoveAt(y);
                        input.RemoveAt(x);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }


            }

            if (flag == false)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", input));
            }
            else if (flag)
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
        }

        static bool IfplayerIsCheating(int x, int y, List<string> input, int moves)
        {
            if (x > input.Count - 1 || x < 0
                || y > input.Count - 1 || y < 0
                || x == y)
            {
                input.Insert(input.Count / 2, $"{moves * -1}a");
                input.Insert(input.Count / 2, $"{moves * -1}a");
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                return false;
            }

            return true;
        }
    }
}