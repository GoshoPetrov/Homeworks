namespace Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> qualityOfDrums = Console.ReadLine().Split().Select(int.Parse).ToList();
            AllDrums(money, qualityOfDrums);
        }

        static void AllDrums (double money, List<int> qualityOfDrums)
        {
            List<int> qualityOfBrockenDrums = new List<int>(qualityOfDrums);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", qualityOfDrums));
                    Console.WriteLine($"Gabsy has {money:F02}lv.");
                    break;
                }

                int power = int.Parse(command);


                for(int i = 0; i < qualityOfDrums.Count; i++)
                {
                    qualityOfDrums[i] -= power;
                    if (qualityOfDrums[i] <= 0)
                    {
                        if (money - qualityOfBrockenDrums[i] * 3 < 0)
                        {
                            qualityOfDrums.RemoveAt(i);
                            qualityOfBrockenDrums.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            money -= qualityOfBrockenDrums[i] * 3;
                            qualityOfDrums[i] = qualityOfBrockenDrums[i];
                        }
                    }
                }
            }
        }
    }
}