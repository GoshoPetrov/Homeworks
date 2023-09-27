namespace Sprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int realGoal = goal + 20;

            int successful = 0;
            int failed = 0;
            int allRuns = 0;

            while(true)
            {
                allRuns++;
                int score = int.Parse(Console.ReadLine());
                if (score >= realGoal) 
                {
                    failed++;
                }
                else if(score < realGoal)
                {
                    successful++;
                }

                if(failed == 2)
                {
                    Console.WriteLine($"Ivan failed at {realGoal}s after {allRuns} runs.");
                    break;
                }

                if(score < goal)
                {
                    Console.WriteLine($"Ivan succeeded, target: {goal}s after {allRuns} runs.");
                    break;
                }

                if(successful == 1)
                {
                    failed = 0;
                    realGoal -= 5;
                }

                successful= 0;


            }
        }
    }
}