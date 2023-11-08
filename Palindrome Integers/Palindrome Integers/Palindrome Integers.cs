namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {

                    break;
                }
                int number = int.Parse(command);
                string num = $"{number}";

                if (PalindromeNumOrNot(num))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool PalindromeNumOrNot(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] == num[num.Length - 1])
                {

                }
                else
                {
                    return false;
                }
            }

            return true;
        }


    }
}