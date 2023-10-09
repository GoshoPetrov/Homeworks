namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int num = int.Parse(Console.ReadLine());

            if(num >= 1 && num <= 7)
            {
                Console.WriteLine(day[num - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}