using System.Data;

namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];

            for(int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for(int col = 0; col < size; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int removed = 0;


            while (true)
            {
                int bestcount = -1;
                int bestcol = -1;
                int bestrow = -1;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            int attacked = CheckIfAttacked(board, row, col);
                            if (bestcount < attacked)
                            {
                                bestcount = attacked;
                                bestcol = col;
                                bestrow = row;
                            }
                        }
                    }
                }

                if (bestcount == 0)
                {
                    break;
                }

                board[bestrow, bestcol] = 'O';
                removed++;

            }
           



            Console.WriteLine(removed);

        }


        static int IsValid(char[,] board, int x, int y)
        {
            int n = board.GetLength(0);
            if (x >= 0 && x < n && y >= 0 && y < n)
            {
                if (board[x, y] == 'K') return 1;
            }
            return 0;
        }

        static int CheckIfAttacked(char[,] board, int row, int col)
        {
            int count = 0;
            
            count += IsValid(board, row - 2, col - 1);
            count += IsValid(board, row + 2, col - 1);
            count += IsValid(board, row + 1, col - 2);
            count += IsValid(board, row - 1, col - 2);

            count += IsValid(board, row - 2, col + 1);
            count += IsValid(board, row - 1, col + 2);
            count += IsValid(board, row + 1, col + 2);
            count += IsValid(board, row + 2, col + 1);


            return count;
        }
    }
}