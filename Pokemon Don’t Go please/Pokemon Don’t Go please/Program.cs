using System.ComponentModel.DataAnnotations;

namespace Pokemon_Don_t_Go_please
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            PlayGame(nums);
        }

        static void PlayGame(List<int> nums)
        {
            int lastIndex = int.MaxValue;
            int removedNum = 0;
            int sumElemnts = 0;

            while (nums.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index > nums.Count - 1)
                {
                    index = nums.Count - 1;
                    removedNum = nums[index];
                }
                else
                {
                    removedNum = nums[index];
                    nums.RemoveAt(index);
                }

                sumElemnts += removedNum;

                if (index < 0)
                {
                    nums[0] = nums[nums.Count - 1];
                }

                if(index > lastIndex)
                {
                    nums[nums.Count - 1] = nums[0];
                }

                lastIndex = index;


                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= removedNum)
                    {
                        nums[i] += removedNum;
                    }
                    else if (nums[i] > removedNum)
                    {
                        nums[i] -= removedNum;
                    }
                }

            }

            Console.WriteLine(sumElemnts);
        }
    }
}