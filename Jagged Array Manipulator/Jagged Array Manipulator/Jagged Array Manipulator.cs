namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            double[][] jagged = new double[size][];

            for(int row = 0; row < jagged.Length; row++)
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jagged[row] = input;

                //jagged[row] = new int[input.Length];

                //for(int col = 0; col < jagged[row].Length; col++)
                //{
                //    jagged[row][col] = input[col];
                //}
            }

            for(int row = 0; row < jagged.Length - 1; row++) 
            {
                
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for(int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] *= 2;
                        jagged[row+ 1][i] *= 2;
                    }
                        
                }
                else
                {
                    for (int i = 0; i < jagged[row].Length; i++)
                    {
                        jagged[row][i] /= 2;
                    }
                    for (int i = 0; i < jagged[row+1].Length; i++)
                    {
                        jagged[row + 1][i] /= 2;
                    }
                }

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Add")
                {
                    int indexRow = int.Parse(command[1]);
                    int indexCol = int.Parse(command[2]);
                    double value = double.Parse(command[3]);

                    if (indexRow < 0 || indexRow >= jagged.Length || indexCol < 0 || indexCol >= jagged[indexRow].Length)
                    {

                    }
                    else
                    {
                        jagged[indexRow][indexCol] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int indexRow = int.Parse(command[1]);
                    int indexCol = int.Parse(command[2]);
                    double value = double.Parse(command[3]);

                    if (indexRow < 0 || indexRow >= jagged.Length || indexCol < 0 || indexCol >= jagged[indexRow].Length)
                    {

                    }
                    else
                    {
                        jagged[indexRow][indexCol] -= value;
                    }

                }
            }

            foreach (double[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }


        }
    }
}