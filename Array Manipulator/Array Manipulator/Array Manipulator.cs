namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] xxx = LastEvenOrOdd(new int[] { 1, 3, 5, 7, 9, 10, 12 }, 2, "even");
            //return;

            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }

                string[] input = command.Split();

                switch (input[0])
                {
                    case "exchange":
                        int index = int.Parse(input[1]);
                        if(index >= 0 && index < arr.Length)
                        {
                            arr = ExchangeIndex(arr, index);

                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "max":
                        int x = MaxEvenOrOdd(arr, input[1]);
                        if (x == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(x);
                        }
                        break;

                    case "min":
                        int y = MinEvenOrOdd(arr, input[1]);
                        if (y == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(y);
                        }
                        break;

                    case "first":
                        if (int.Parse(input[1]) <= arr.Length)
                        {
                            int[] result = FirstEvenOrOdd(arr, int.Parse(input[1]), input[2]);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    case "last":
                        if (int.Parse(input[1]) <= arr.Length)
                        {
                            int[] result = LastEvenOrOdd(arr, int.Parse(input[1]), input[2]);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", arr)}]");

        }

        private static int[] FirstEvenOrOdd(int[] arr, int n, string evenOrOdd)
        {

            int reminder = 0;
            if (evenOrOdd == "odd")
            {
                reminder = 1;
            }

            int cnt = 0;
            foreach (int a in arr)
            {
                if (a % 2 == reminder)
                {
                    cnt++;
                    if (cnt == n)
                    {
                        break;
                    }
                }
            }

            int[] result = new int[cnt];

            int index = 0;
            foreach (int a in arr)
            {
                if (a % 2 == reminder)
                {
                    if (index == n)
                    {
                        break;
                    }

                    result[index] = a;
                    index++;

                }
            }
            
            return result;
            
        }

        private static int[] LastEvenOrOdd(int[] arr, int n, string evenOrOdd)
        {

            int reminder = 0;
            if (evenOrOdd == "odd")
            {
                reminder = 1;
            }

            int cnt = 0;
            for (int i=arr.Length-1; i>=0; i--)
            {
                int a = arr[i];
                if (a % 2 == reminder)
                {
                    cnt++;
                    if (cnt == n)
                    {
                        break;
                    }
                }
            }

            int[] result = new int[cnt];

            int index = result.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int a = arr[i];
                if (a % 2 == reminder)
                {
                    result[index] = a;
                    index--;

                    if (index < 0)
                    {
                        break;
                    }
                }
            }

            return result;

        }

        private static int MaxEvenOrOdd(int[] arr, string evenOrOdd)
        {
            int bestIndex = -1;

            int reminder = 0;
            if (evenOrOdd == "odd")
            {
                reminder = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == reminder)
                {
                    if (bestIndex == -1 || arr[i] >= arr[bestIndex])
                    {
                        bestIndex = i;
                    }
                }
            }

            return bestIndex;
        }

        private static int MinEvenOrOdd(int[] arr, string evenOrOdd)
        {
            int bestIndex = -1;

            int reminder = 0;
            if (evenOrOdd == "odd")
            {
                reminder = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == reminder)
                {
                    if (bestIndex == -1 || arr[i] <= arr[bestIndex])
                    {
                        bestIndex = i;
                    }
                }
            }

            return bestIndex;
        }

        private static int[] ExchangeIndex(int[] arr, int index)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length - index - 1; i++)
            {
                result[i] = arr[index + 1 + i];
            }

            int start = arr.Length - index - 1;
            for (int j = 0; j <= index; j++) 
            {
                result[start + j] = arr[j];
            }

            return result;
        }
    }
}