namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;

            int totalAmount = 0;

            while (true)
            {
                days++;

                totalAmount += yield;

                // end of shift
                if (totalAmount >= 26)
                {
                    totalAmount -= 26; // crew eat
                }
                else
                {
                    // crew will not eat
                }

                yield -= 10;

                if (yield < 100)
                {
                    // the mine is exausted...
                    if (totalAmount >= 26)
                    {
                        totalAmount -= 26;
                    }
                    Console.WriteLine(days);
                    Console.WriteLine(totalAmount);
                    break;
                }

            }

        }
    }
}