﻿namespace Applied_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    nums = nums.Select(x => x + 1).ToList();
                }
                else if (command == "multiply")
                {
                    nums = nums.Select(x => x * 1).ToList();
                }
                else if (command == "subtract")
                {
                    nums = nums.Select(x => x - 1).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                }
            }
        }
    }
}