namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int index in indexes)
            {
                if (index < 0 || index >= size)
                {
                    continue;
                }
                field[index] = 1;
            }


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] parts = command.Split();

                int ladyBugIndex = int.Parse(parts[0]);
                int flyLenght = int.Parse(parts[2]);

                if (parts[1] == "left")
                {
                    flyLenght *= -1;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;
                do
                {
                    ladyBugIndex += flyLenght;
                } while (ladyBugIndex >= 0 && ladyBugIndex < size && field[ladyBugIndex] == 1);

                if (ladyBugIndex >= 0 && ladyBugIndex < size)
                {
                    field[ladyBugIndex] = 1;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}