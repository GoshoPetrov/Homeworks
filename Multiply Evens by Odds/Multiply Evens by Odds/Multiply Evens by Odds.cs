using System;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = Math.Abs(number);
            GetSumOfEvenDigits(num);
            GetSumOfOddDigits(num);
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;
            while(num > 0)
            {
                int digit = num % 10;
                if(digit % 2 == 0)
                {
                    evenSum += digit;
                }

                num = num / 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                num = num / 10;
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            int even = GetSumOfEvenDigits(num);
            int odd = GetSumOfOddDigits(num);
            int result = even * odd;
            return result;
        }

    }
}