namespace Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GaussTrick();
        }

        static void GaussTrick()
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] = nums[i] + nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);

            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}