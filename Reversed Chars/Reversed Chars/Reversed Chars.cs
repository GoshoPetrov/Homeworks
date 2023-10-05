namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char numOne = char.Parse(Console.ReadLine());
            char numTwo = char.Parse(Console.ReadLine());
            char numThree = char.Parse(Console.ReadLine());
            Console.WriteLine($"{numThree} {numTwo} {numOne}");
        }
    }
}