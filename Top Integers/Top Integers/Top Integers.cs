namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0; i < arr.Length-1; i++)
            {
                bool greaterNot = true;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        greaterNot = false;
                        break;
                    }
                }
                if (greaterNot)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.Write(arr[arr.Length - 1]);

        }
    }
}