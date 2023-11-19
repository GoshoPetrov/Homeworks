using System.Collections.Concurrent;

namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }

                string[] parts = command.Split(" ");
                switch (parts[0])
                {
                    case "merge":
                        int startIndex = int.Parse(parts[1]);
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }

                        int endIndex = int.Parse(parts[2]);
                        if (endIndex > data.Count - 1)
                        {
                            endIndex = data.Count - 1;
                        }

                        Merge(data, startIndex, endIndex);

                        break;

                    case "divide":

                        int index = int.Parse(parts[1]);
                        int partitions = int.Parse(parts[2]);

                        Divide(data, index, partitions);

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static void Divide(List<string> data, int index, int partitions)
        {
            if (partitions == 0)
            {
                return;
            }

            string s = data[index];
            data.RemoveAt(index);

            int l = s.Length / partitions;

            for (int i = 0; i < partitions - 1; i++)
            {
                string p = s.Substring(0, l);
                data.Insert(index + i, p);
                s = s.Substring(l);
            }

            data.Insert(index + partitions - 1, s);
        }

        private static void Merge(List<string> data, int startIndex, int endIndex)
        {
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                data[startIndex] += data[startIndex + 1];
                data.RemoveAt(startIndex + 1);
            }
        }
    }
}