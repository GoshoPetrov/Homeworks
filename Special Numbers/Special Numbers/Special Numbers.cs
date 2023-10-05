namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool result = false;

            for(int i = 1; i <= n; i++)
            {
                num = i;
                while(true)
                {
                    sum += num%10;
                    num = num / 10;
                    if(num <= 0)
                    {
                        break;
                    }
                }

                if(sum == 5 || sum == 7 || sum == 11)
                {
                    result = true;
                }

                Console.WriteLine($"{i} -> {result}");
                
                sum= 0;
                result= false;
                

            }
        }
    }
}