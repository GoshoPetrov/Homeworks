namespace Train2
{
    internal class Train
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());

            TrainWagons(nums, max);
        }

        static void TrainWagons(List<int> nums, int max)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] parts = command.Split();

                if (parts[0] == "Add")
                {
                    nums.Add(int.Parse(parts[1]));
                }
                else
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] + int.Parse(parts[0]) <= max)
                        {
                            nums[i] += int.Parse(parts[0]);
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}