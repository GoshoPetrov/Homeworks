namespace List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ListOfProducts(n);
        }

        static void ListOfProducts(int n)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}