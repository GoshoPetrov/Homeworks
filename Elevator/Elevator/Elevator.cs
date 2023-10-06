namespace Elevator
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int pCapacity = int.Parse(Console.ReadLine());
            int courses = 0;

            for(int i = 0; i < nPeople; i+=pCapacity)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}