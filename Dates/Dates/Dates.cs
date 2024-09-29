namespace Dates
{
    internal class Dates 
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();


            DateCounter dates = new DateCounter();

            Console.WriteLine(dates.CalculateDifference(date1, date2));

        }
    }
}
