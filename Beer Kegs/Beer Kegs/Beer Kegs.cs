using System.Runtime.CompilerServices;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double bestSum = 0;
            string bestModel = null;

            for(int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                sum = (Math.PI * radius * height)/2;

                if(bestSum < sum)
                {
                    bestSum = sum;
                    bestModel = model;
                }

            }

            Console.WriteLine(bestModel);

        }
    }
}