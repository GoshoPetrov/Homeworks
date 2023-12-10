namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(list);

            while(songs.Count != 0)
            {
                string[] command = Console.ReadLine().Split(" ", 2);

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    if (songs.Contains(command[1]))
                    {
                        Console.WriteLine($"{command[1]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(command[1]);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}