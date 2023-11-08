namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckCount(password);
        }

        
        static void CheckCount(string password)
        {
            if(password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                CheckOnlyDigitsAndLetters(password);
            }
            else
            {
                CheckOnlyDigitsAndLetters(password);
            }
        }

        static void CheckOnlyDigitsAndLetters(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetterOrDigit(password[i]))
                {

                }
                else
                {
                    count++;
                }
            }
                
                if(count == 0)
                {
                    CheckAtLeastTwoDigits(password);
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    CheckAtLeastTwoDigits(password);
                }
                
            
        }

        static void CheckAtLeastTwoDigits(string password)
        {
            int countDigit = 0;
            for(int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    countDigit++;
                }
            }

            if(countDigit < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}