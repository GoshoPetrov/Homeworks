namespace List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManipulationAdvanced();
        }

        static void ListManipulationAdvanced()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> nums = new List<int> { 2, 13, 43, 876, 342, 23, 543, };

            bool hasChanges = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] parts = command.Split();

                switch (parts[0])
                {
                    case "Add":
                        nums.Add(int.Parse(parts[1]));
                        hasChanges = true;
                        break;

                    case "Remove":
                        nums.Remove(int.Parse(parts[1]));
                        hasChanges = true;
                        break;

                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(parts[1]));
                        hasChanges = true;

                        break;

                    case "Insert":
                        nums.Insert(int.Parse(parts[2]), int.Parse(parts[1]));
                        hasChanges = true;

                        break;

                    case "Contains":
                        if (nums.Contains(int.Parse(parts[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {
                                Console.Write($"{nums[i]} ");
                            }

                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                Console.Write($"{nums[i]} ");
                            }

                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum += nums[i];
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        if (parts[1] == "<")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] < int.Parse(parts[2]))
                                {
                                    Console.Write($"{nums[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (parts[1] == ">")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] > int.Parse(parts[2]))
                                {
                                    Console.Write($"{nums[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (parts[1] == ">=")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] >= int.Parse(parts[2]))
                                {
                                    Console.Write($"{nums[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (parts[1] == "<=")
                        {
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] <= int.Parse(parts[2]))
                                {
                                    Console.Write($"{nums[i]} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }


            }
            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", nums));
            }

        }
    }
}