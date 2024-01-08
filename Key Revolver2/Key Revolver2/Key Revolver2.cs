namespace Key_Revolver2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> num = new Queue<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) 
                {
                    num.Enqueue(nums[i]);
                }
            }

            Console.WriteLine(string.Join(", ", num));
            
        }
    }
}