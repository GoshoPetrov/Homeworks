using System.Runtime.ExceptionServices;
using System.Runtime.Remoting;

namespace LadyBugs48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            int[] ladyBug = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach(int n in ladyBug)
            {
                field[n] = 1;
            }

            //Console.WriteLine(string.Join(" ", field));

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

                if (input[1] == "left")
                {
                    fly = fly * -1;
                }

                // move the bug from index bug to new index

                field[bug] = 0;

                while (bug + fly < size && bug + fly >= 0 && field[bug + fly] == 1)
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