namespace List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManipulation();
        }

        static void ListManipulation()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] arr = command.Split();

                switch (arr[0])
                {
                    case "Add":
                        nums.Add(int.Parse(arr[1]));
                        break;

                    case "Remove":
                        nums.Remove(int.Parse(arr[1]));
                        break;

                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(arr[1]));
                        break;

                    case "Insert":
                        nums.Insert(int.Parse(arr[2]), int.Parse(arr[1]));
                        break;
                }


            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}