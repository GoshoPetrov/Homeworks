namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string numbers = Console.ReadLine();
            string[] parts = numbers.Split();

            int bomb = int.Parse(parts[0]);
            int power = int.Parse(parts[1]);

            while (Explode(nums, bomb, power))
            {

            }

            int sum = 0;
            foreach (int n in nums)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }

        private static bool Explode(List<int> nums, int bomb, int power)
        {
            int index = nums.IndexOf(bomb);
            if (index < 0) return false;

            int startIndex = index - power;
            int endIndex = index + power;

            if (startIndex < 0) startIndex = 0;
            if (endIndex > nums.Count - 1) endIndex = nums.Count - 1;

            for (int i = 0; i < endIndex - startIndex + 1; i++)
            {
                nums.RemoveAt(startIndex);
            }

            return true;
        }
    }
}