namespace List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, bool> check = x =>
            {
                foreach (int item in nums)
                {
                    if (x % item != 0)
                    {
                        return false;
                        continue;
                    }
                }

                return true;
            };

            List<int> specialNums = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (check(i))
                {
                    specialNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", specialNums));
        }
    }
}
