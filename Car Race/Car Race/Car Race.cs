namespace Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int[] nums = { 29, 13, 9, 0, 13, 0, 21, 0, 14, 82, 12, };

            double left = r(LeftRace(nums));
            double right = r(RightRace(nums));


            if (left > right)
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
        }

        static double r(double a)
        {
            double k = 100000;
            return Math.Round(a * k) / k;
        }

        static double LeftRace(int[] nums)
        {
            double sumOfNumsLeft = 0;
            for(int i = 0; i < nums.Length/2; i++)
            {
                if (nums[i] == 0)
                {
                    sumOfNumsLeft = sumOfNumsLeft * 0.8;
                }
                sumOfNumsLeft += nums[i];
            }

            return sumOfNumsLeft;
        }

        static double RightRace(int[] nums)
        {
            double sumOfNumsRight = 0;
            for (int i = nums.Length - 1; i > nums.Length / 2; i--)
            {
                if (nums[i] == 0)
                {
                    sumOfNumsRight = sumOfNumsRight * 0.8;
                }
                sumOfNumsRight += nums[i];
            }
            return sumOfNumsRight;
        }
    }
}