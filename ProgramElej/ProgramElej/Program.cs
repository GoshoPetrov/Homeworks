namespace ProgramElej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(nums);

            int sum = 0;

            while(stack.Count != 0)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == "+")
                    {
                        stack.Push(nums[i - 1] + nums[i + 1]);
                    }
                    else if (nums[i] == "-")
                    {
                        stack.Push(int.Parse(nums[i - 1]) - int.Parse(nums[i + 1]));
                    }
                    else if (nums[i] == "*")
                    {
                        stack.Push(int.Parse(nums[i - 1]) * int.Parse(nums[i + 1]));
                    }
                    else if (nums[i] == "/")
                    {
                        stack.Push(int.Parse(nums[i - 1]) / int.Parse(nums[i + 1]));
                    }
                }
            }
        }
    }
}