namespace TakeSkip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            //string message = "this forbidden mess of an age rating 0127504740";

            string result = DecryptMessage(message);
            Console.WriteLine(result);
        }

        static string DecryptMessage(string message)
        {
            string nonNumList = null;
            string numList = null;

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numList += message[i];
                }
                else
                {
                    nonNumList += message[i];
                }
            }

            string result = null;
            int current = 0;
            for (int j = 0; j < numList.Length; j += 2)
            {
                int take = numList[j] - '0';
                int skip = numList[j + 1] - '0';

                if (current + take > nonNumList.Length)
                {
                    take = nonNumList.Length - current;
                }
                string takeWhat = nonNumList.Substring(current, take);
                result += takeWhat;
                current += take;
                current += skip;
            }

            return result;

        }
    }
}