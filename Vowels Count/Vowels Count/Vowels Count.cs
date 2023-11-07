namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(CheckVowelLetters(word));
        }

        static string CheckVowelLetters(string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' || word[i] == 'o' || word[i] == 'O' || word[i] == 'i' || word[i] == 'I' || word[i] == 'e' || word[i] == 'E' || word[i] == 'u' || word[i] == 'U')
                {
                    count++;
                }
            }

            return count.ToString();
        }
    }
}