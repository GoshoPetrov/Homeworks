namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            for(int i = 0; i < arr.Length / 2; i++)
            {
                var x = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = x;
                
            }

            foreach(var x in arr)
            {
                Console.Write($"{x} ");
            }


        }
    }
}