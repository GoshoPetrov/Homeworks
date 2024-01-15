namespace Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] lair = new char[size[0], size[1]];

            int playerX = 0;
            int playerY = 0;

            for (int row = 0; row < size[0]; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size[1]; col++)
                {
                    lair[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        playerX = row;
                        playerY = col;
                    }
                }
            }


            string commands = Console.ReadLine();

            //PrintLAier(lair);

            for (int i = 0; i < commands.Length; i++)
            {
                lair[playerX, playerY] = '.';
                if (commands[i] == 'L')
                {
                    if (playerY > 0)
                    {
                        playerY -= 1;
                    }
                    else
                    {
                        Console.WriteLine($"won: {playerX} {playerY}");
                        break;
                    }

                }
                else if (commands[i] == 'R')
                {
                    if (playerY < lair.GetLength(0))
                    {
                        playerY += 1;
                    }
                    else
                    {
                        Console.WriteLine($"won: {playerX} {playerY}");
                        break;
                    }


                }
                else if (commands[i] == 'U')
                {
                    if (playerX > 0)
                    {
                        playerX -= 1;
                    }
                    else
                    {
                        Console.WriteLine($"won: {playerX} {playerY}");
                        break;
                    }

                }
                else if (commands[i] == 'D')
                {
                    if (playerX < lair.GetLength(1))
                    {
                        playerX += 1;
                    }
                    else
                    {
                        Console.WriteLine($"won: {playerX} {playerY}");
                        break;
                    }
                }

                Spawn(lair);

                if (CheckIfDead(playerX, playerY, lair))
                {
                    Console.WriteLine($"dead: {playerX} {playerY}");
                    break;
                }
                lair[playerX, playerY] = 'P';

                //PrintLAier(lair);



            }

            PrintLAier(lair);


        }

        private static void PrintLAier(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write($"{lair[row, col]}");
                }
                Console.WriteLine();
            }
        }

        static void Spawn(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (BunnyNeighbour(row, col, lair))
                    {
                        lair[row, col] = 'X';
                    }
                }
            }

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'X')
                    {
                        lair[row, col] = 'B';
                    }
                }
            }
        }

        static bool BunnyNeighbour(int row, int col, char[,] lair)
        {
            if (GetLair(row - 1, col, lair) == 'B'
                || GetLair(row + 1, col, lair) == 'B'
                || GetLair(row, col - 1, lair) == 'B'
                || GetLair(row, col + 1, lair) == 'B'
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static char GetLair(int row, int col, char[,] lair)
        {
            if (row < 0 || row >= lair.GetLength(0) || col < 0 || col >= lair.GetLength(1))
            {
                return '\0';
            }
            return lair[row, col];

        }

        static void SetLair(int row, int col, char[,] lair, char value)
        {
            if(row < 0 || row >= lair.GetLength(0) || col < 0 || col >= lair.GetLength(1))
            {
                return;
            }
            lair[row, col] = value;
        }


        static bool CheckIfDead(int playerX, int playerY, char[,] lair)
        {
            if (lair[playerX, playerY] == 'B')
            {
                return true;
            }

            return false;
        }
    }
}