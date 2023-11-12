using System;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            TopNumOrNot(num);
        }

        static void TopNumOrNot(int num)
        {
            int digitsSum = 0;
            int useNum = 0;

            for (int f = 11; f < num; f++)
            {
                useNum = f;
                string ourNum = $"{useNum}";

                for (int j = 0; j < ourNum.Length; j++)
                {
                    digitsSum += (int)ourNum[j] - (int)'0';
                }

                for (int i = 0; i < ourNum.Length; i++)
                { 
                    if (digitsSum % 8 == 0)
                    {
                        if (((int)ourNum[i] - (int)'0') % 2 != 0)
                        {
                            Console.WriteLine(useNum);
                            break;
                        }
                        
                    }

                    
                }
                digitsSum = 0;
            }

            
        }
    }
}