namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int capacity = 0;
            
            for(int i = 1; i < n + 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                liters += num;

                if(liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    liters -= num;
                }
                

            }

            Console.WriteLine(liters);
        }
    }
}