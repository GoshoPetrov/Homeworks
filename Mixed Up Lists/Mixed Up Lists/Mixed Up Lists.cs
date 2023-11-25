using System.Globalization;

namespace Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> ListTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            //List<int> ListOne = new List<int>{ 1, 5, 23, 64, 2, 3, 34, 54, 12 };
            //List<int> ListTwo = new List<int> { 43, 23, 12, 31, 54, 51, 92 };

            MixingLists(ListOne, ListTwo);
        }

        static void MixingLists(List<int> ListOne, List<int> ListTwo)
        {
            List<int> result = new List<int>();

            while (ListTwo.Count != 0 && ListOne.Count != 0)
            {
                result.Add(ListOne[0]);
                ListOne.RemoveAt(0);

                result.Add(ListTwo[ListTwo.Count - 1]);
                ListTwo.RemoveAt(ListTwo.Count - 1);
            }

            List<int> remaining = ListOne;
            if (remaining.Count == 0)
            {
                remaining = ListTwo;
            }

            int min = remaining[0];
            int max = remaining[1];

            if (min > max)
            {
                int t = min;
                min = max;
                max = t;
            }

            List<int> tl = new List<int>();

            foreach (int x in result)
            {
                if (x > min && x < max)
                {
                    tl.Add(x);
                }
            }

            tl.Sort();

            Console.WriteLine(string.Join(" ", tl));
        }
    }
}