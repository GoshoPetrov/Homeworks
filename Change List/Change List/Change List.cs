namespace Change_List
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

                if (command == "end")
                {
                    break;
                }

                string[] parts = command.Split();

                switch (parts[0])
                {
                    case "Delete":
                        while (nums.Remove(int.Parse(parts[1])))
                        {

                        }
                        break;

                    case "Insert":
                        nums.Insert(int.Parse(parts[2]), int.Parse(parts[1]));
                        break;
                }

            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}