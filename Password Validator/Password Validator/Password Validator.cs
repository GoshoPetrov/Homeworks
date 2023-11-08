namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool allok = true;
            if (CheckCount(password))
            {
                allok = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckOnlyDigitsAndLetters(password))
            {
                allok = false;

                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CheckAtLeastTwoDigits(password))
            {
                allok = false;

                Console.WriteLine("Password must have at least 2 digits");
            }

            if (allok)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckCount(string password)
        {
            return password.Length < 6;
        }

        private static bool CheckOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckAtLeastTwoDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return true;
            }

            return false;
        }
    }
}