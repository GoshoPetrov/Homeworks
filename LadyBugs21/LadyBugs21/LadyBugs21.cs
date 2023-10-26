namespace LadyBugs21
{
    internal class LadyBugs21
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            int[] ladyBug = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int n in ladyBug)
            {
                if(n >= 0 && n < size)
                {
                    field[n] = 1;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }

                string[] input = command.Split();

                int bug = int.Parse(input[0]);
                int fly = int.Parse(input[2]);

                field[bug] = 0;

                while (bug + fly < size && bug + fly >= 0 && field[bug + fly] != 1)
                {
                    fly += fly;
                }

                if(bug + fly < size && bug + fly >= 0)
                {
                    field[bug + fly] = 1;
                }
                    


            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}