namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if(char.IsUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
            else if(char.IsLower(letter))
            {
                Console.WriteLine("lower-case");
            }
            
        }
    }
}