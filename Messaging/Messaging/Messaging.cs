using System.Globalization;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string text = Console.ReadLine();

            Messaging(nums, text);
        }

        static void Messaging(List<int> nums, string text)
        {
            int sumOfDigits = 0;
            string result = null;
            
            for(int i = 0; i < nums.Count; i++)
            {
                while (nums[i] > 0)
                {
                    sumOfDigits += nums[i] % 10;
                    nums[i] = nums[i] / 10;
                }
                if (sumOfDigits > text.Length)
                {
                    sumOfDigits = sumOfDigits - text.Length;
                }

                result += text[sumOfDigits];
                text = text.Remove(sumOfDigits, 1);
                sumOfDigits = 0;
            }

            Console.WriteLine(result);

        }

        static int DigitSum(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num = num / 10;
            }
            return result
        }
    }
}