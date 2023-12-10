namespace Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            BakanceTheBrackets(parentheses);

        }

        private static void BakanceTheBrackets(string parentheses)
        {
            Stack<char> brackets = new Stack<char>();

            bool flag = true;

            for (int i = 0; i < parentheses.Length; i++)
            {
                if (parentheses[i] == '{')
                {
                    brackets.Push(parentheses[i]);
                }
                else if (parentheses[i] == '[')
                {
                    brackets.Push(parentheses[i]);
                }
                else if (parentheses[i] == '(')
                {
                    brackets.Push(parentheses[i]);
                }
                else if (parentheses[i] == '}')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '{')
                    {
                        Console.WriteLine("NO");
                        flag = false;
                        break;
                    }
                }
                else if (parentheses[i] == ']')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '[')
                    {
                        Console.WriteLine("NO");
                        flag = false;
                        break;
                    }
                }
                else if (parentheses[i] == ')')
                {
                    if (brackets.Count == 0 || brackets.Pop() != '(')
                    {
                        Console.WriteLine("NO");
                        flag = false;
                        break;
                    }
                }


            }

            if (flag)
            {
                Console.WriteLine("YES");
            }
        }
    }
}