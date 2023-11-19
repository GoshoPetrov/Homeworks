using System.Globalization;

namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MergingLists();
        }

        static void MergingLists()
        {
            List<int> numsOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numsTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            while (numsOne.Count > 0 || numsTwo.Count > 0)
            {
                if (numsOne.Count > 0)
                {
                    result.Add(numsOne[0]);
                    numsOne.RemoveAt(0);
                }

                if (numsTwo.Count > 0)
                {
                    result.Add(numsTwo[0]);
                    numsTwo.RemoveAt(0);
                }
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}