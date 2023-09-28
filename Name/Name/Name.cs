namespace Name
{
    internal class Name
    {
        static void Main(string[] args)
        {

            int bestScore = 0;
            string bestName = null;
            int score = 0;
            while (true)
            {
                string name = Console.ReadLine();
                if(name == "End")
                {
                    Console.WriteLine($"The most interesting name is {bestName} - {bestScore}");
                    break;
                }

                for(int i = 0; i < name.Length; i++)
                {
                    int y = (int)name[i];
                    score += y;

                    if (name[i] == 'a' || 
                        name[i] == 'e' || 
                        name[i] == 'i' || 
                        name[i] == 'o' ||
                        name[i] == 'u' ||
                        name[i] == 'y')
                    {
                        score += 10;
                    }


                }

                if(score >= bestScore)
                {
                    bestScore = score;
                    bestName = name;
                }

                score= 0;

            }
        }
    }
}