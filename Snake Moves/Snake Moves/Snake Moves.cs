namespace Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string snake = Console.ReadLine();

            char[,] isle = new char[size[0], size[1]];

            int snakeCol = -1;

            for(int row = 0; row < size[0]; row++)
            {
                for(int col = 0; col < size[1]; col++)
                {
                    snakeCol++;
                    if(row % 2 != 0)
                    {
                        if(snakeCol >= snake.Length)
                        {
                            snakeCol = 0;
                        }
                        isle[row, size[1] - col - 1] = snake[snakeCol];
                    }
                    else
                    {
                        if (snakeCol >= snake.Length)
                        {
                            snakeCol = 0;
                        }
                        isle[row, col] = snake[snakeCol];
                    }
                }
            }

            for(int row = 0; row < size[0]; row++)
            {
                for(int col = 0; col < size[1]; col ++)
                {
                    Console.Write($"{isle[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}