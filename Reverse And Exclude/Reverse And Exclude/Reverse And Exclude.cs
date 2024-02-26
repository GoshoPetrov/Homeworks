namespace Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            nums = nums.Where(x => x != 0.0 && x % n != 0).ToList();
            nums.Reverse();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}