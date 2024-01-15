namespace Bombs
{
    internal class Bombs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] board = new int[size, size];

            for(int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < size; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int[][] bombs = Console.ReadLine()
                .Split(" ")
                .Select((x) => x.Split(",").Select(int.Parse).ToArray())
                .ToArray();

            for (int bombIndex = 0; bombIndex < bombs.GetLength(0); bombIndex++)
            {
                int[] bomb = bombs[bombIndex];
                if (board[bomb[0], bomb[1]] > 0)
                {
                    BombRadius(board, bomb[0], bomb[1], board[bomb[0], bomb[1]]);
                }
            }

            int sum = 0;
            int count = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (board[row, col] > 0)
                    {
                        sum += board[row, col];
                        count++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row =0; row < board.GetLength(0); row ++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write($"{board[row, col]} ");
                }
                Console.WriteLine();

            }
        }

        static void Reduce(int[,] board, int row, int col, int value)
        {
            if (row < 0 || row >= board.GetLength(0)) return;
            if (col < 0 || col >= board.GetLength(1)) return;
            if (board[row, col] < 1) return;
            board[row, col] -= value;
        }

        static void BombRadius(int[,] board, int row, int col, int value)
        {
            Reduce(board, row - 1, col, value);
            Reduce(board, row + 1, col, value);
            Reduce(board, row, col - 1, value);
            Reduce(board, row, col + 1, value);
            Reduce(board, row - 1, col - 1, value);
            Reduce(board, row + 1, col + 1, value);
            Reduce(board, row - 1, col + 1, value);
            Reduce(board, row + 1, col - 1, value);

            board[row, col] = 0;
        }
    }
}