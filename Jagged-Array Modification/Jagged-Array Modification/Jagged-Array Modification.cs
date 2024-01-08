namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jagged = new int[size][];

            for(int row = 0; row < jagged.Length; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];
                for(int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row < 0 || row > jagged.Length - 1 || col < 0 || col > jagged.Length - 1)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row < 0 || row > jagged.Length || col < 0 || col > jagged.Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}