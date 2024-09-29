using System.Security.Cryptography;

namespace Randomize_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] faces = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = new string[] {"Spades", "Diamonds", "Clubs", "Hearts" };

            List<Card> all = new List<Card>();
            foreach (var f in faces)
            {
                foreach (var s in suits)
                {
                    all.Add(new Card(f, s));
                }
            }

            var rnd = new Random();
            while (all.Count > 0)
            {
                int randomIndex = rnd.Next(0, all.Count);
                Console.WriteLine(all[randomIndex].Print());
                all.RemoveAt(randomIndex);
            }
            
        }
    }
}
