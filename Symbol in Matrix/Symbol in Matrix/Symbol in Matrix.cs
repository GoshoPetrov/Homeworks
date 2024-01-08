namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] value = new string[size, size];

            bool flag = true;

            for(int row = 0; row < size; row++)
            {
                //char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();

                string input = Console.ReadLine();
                
                for(int col = 0; col < size; col++)
                {
                    value[row, col] = input[col];
                }
            }

            string character = Console.ReadLine();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if(character == value[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        flag = false;
                        break;
                    }
                }

                if (flag == false)
                {
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine($"{character} does not occur in the matrix");
            }
            
        }
    }
}