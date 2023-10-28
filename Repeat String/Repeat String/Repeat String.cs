using System.Diagnostics.Tracing;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(word, count));
        }

        static string RepeatString(string word, int count)
        {
            string newWord = null;
            for(int i = 0; i < count; i++)
            {
                newWord += word;
            }
            return newWord;
        }
    }
}