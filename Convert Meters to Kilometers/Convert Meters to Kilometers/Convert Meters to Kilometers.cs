namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            float kilometers = metres / 1000.0f;
            Console.WriteLine($"{kilometers:F02}");
        }
    }
}