namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string text = "";
            Stack<string> undo = new Stack<string>();

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    undo.Push(text);
                    text += command[1];
                }
                else if (command[0] == "2")
                {
                    undo.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(command[1]));
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(command[1])-1]);
                }
                else if (command[0] == "4")
                {
                    text = undo.Pop();
                }
            }
        }
    }
}