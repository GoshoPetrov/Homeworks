namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveNegativeNums();
        }

        static void RemoveNegativeNums()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i <= nums.Count - 1; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                    i = -1;
                }
            }

            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }

    }
}