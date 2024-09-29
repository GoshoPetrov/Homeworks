namespace Class_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> list = new List<Card>
            {
                new Card("A", "Spades"),
                new Card("J", "Diamond"),
                new Card("Q", "Clubs"),
                new Card("10", "Hearts")
            };

            foreach(var item in list)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
