namespace Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] value = new int[size[0], size[1]];

            for(int row = 0; row < size[0]; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < size[1]; col++)
                {
                    value[row, col] = input[col];
                }
            }

            int maxSum = 0;

            int indexRow = 0;
            int indexCol = 0;

            for(int row = 0; row < size[0] - 1; row++)
            { 

                for(int col = 0; col < size[1] - 1; col++)
                {
                    int sum = 
                        value[row, col] + 
                        value[row+1, col] + 
                        value[row, col+1] + 
                        value[row+1, col+1];

                    if(maxSum < sum)
                    {
                        maxSum = sum;
                        indexRow = row;
                        indexCol = col;
                    }

                }
            }



            Console.WriteLine(
@$"{value[indexRow, indexCol]} {value[indexRow, indexCol+1]}
{value[indexRow+1, indexCol]} {value[indexRow + 1, indexCol + 1]}
{maxSum}");

        }
    }
}