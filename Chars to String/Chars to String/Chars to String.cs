namespace Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());
            char inputThree = char.Parse(Console.ReadLine());

            string sum = $"{inputOne}{inputTwo}{inputThree}";

            Console.WriteLine(sum);
}
    }
}