namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            ChangeList(nums);
        }

        static void ChangeList(List<int> nums)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] parts = command.Split();

                switch (parts[0])
                {
                    case "Add":
                        nums.Add(int.Parse(parts[1]));
                        break;

                    case "Insert":
                        {
                            int index = int.Parse(parts[2]);
                            if (index < 0 || index >= nums.Count)
                            {
                                Console.WriteLine("Invalid index");
                            }
                            else
                            {
                                nums.Insert(index, int.Parse(parts[1]));
                            }
                            break;
                        }

                    case "Remove":
                        {
                            int index = int.Parse(parts[1]);
                            if (index < 0 || index >= nums.Count)
                            {
                                Console.WriteLine("Invalid index");
                            }
                            else
                            {
                                nums.RemoveAt(index);
                            }
                            break;
                        }

                    case "Shift":
                        if (parts[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(parts[2]); i++)
                            {
                                int first = nums[0];
                                nums.RemoveAt(0);
                                nums.Add(first);
                            }

                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(parts[2]); i++)
                            {
                                int last = nums[nums.Count - 1];
                                nums.RemoveAt(nums.Count - 1);
                                nums.Insert(0, last);
                            }

                        }
                        break;

                }

            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}