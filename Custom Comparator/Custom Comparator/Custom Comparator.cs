namespace Custom_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> isEven = x => x % 2 == 0;
            Func<int, bool> isOdd = x => x % 2 != 0;

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var evens = nums.Where(isEven).ToList();
            var odds = nums.Where(isOdd).ToList();

            evens.Sort();
            odds.Sort();

            Console.Write($"{string.Join(" ", evens)} ");
            Console.Write(string.Join(" ", odds));
        }
    }
}
