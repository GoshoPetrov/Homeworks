namespace LadyBugs42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            int[] ladyBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int n in ladyBugs)
            {
                if(n >= 0 && n < size)
                {
                    field[n] = 1;
                }
            }

            //Console.WriteLine(string.Join(" ", field));

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }

                string[] info = Console.ReadLine().Split();

                int bug = int.Parse(info[0]);
                int fly = int.Parse(info[2]);

                if (info[1] == "left")
                {
                    fly = fly * -1;
                }

                field[bug] = 0;

                while (field[bug + fly] == 1)
                {
                    fly += fly;
                    if (bug + fly >= size && bug + fly < 0)
                    {
                        break;
                    }
                }


                if (bug + fly < size && bug + fly >= 0)
                {
                    field[bug + fly] = 1;
                }
                


            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}