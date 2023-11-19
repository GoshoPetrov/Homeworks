namespace Pokemon_Don_t_Go
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
            int removedNum = 0;
            int sumOfRemovedNums = 0;
            int count = 0;
            int lastIndex = 0;
            for(int i = 0; i < nums.Count; i++)
            {
                count++;
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    nums[0] = nums[nums.Count - 1];
                }

                if(count > 1)
                {
                    if (lastIndex < index)
                    {
                        nums[nums.Count - 1] = nums[0];
                    }
                }
                


                lastIndex = index;

                if(index > nums.Count - 1)
                {
                    index = nums.Count - 1;
                    removedNum = nums[index];
                }
                else
                {
                    removedNum = nums[index];
                    nums.RemoveAt(index);
                }

                sumOfRemovedNums += removedNum;

                for(int j = 0; j < nums.Count; j++)
                {
                    if (nums[j] <= removedNum)
                    {
                        nums[j] += removedNum;
                    }
                    else if (nums[j] > removedNum)
                    {
                        nums[j] -= removedNum;
                    }
                }


                i = -1;
            }

            Console.WriteLine(sumOfRemovedNums);
        }
    }
}