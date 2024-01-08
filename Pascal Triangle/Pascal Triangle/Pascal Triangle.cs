namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());


            long[][] pascal = new long[border][];


            List<long> row = new List<long>() { 1 };
            Console.WriteLine(string.Join(" ", row));



            for (int i=0; i< border-1; i++)
            {
                pascal[i] = row.ToArray();

                List<long> nextRow = Pascal(row);

                row = nextRow;
                Console.WriteLine(string.Join(" ", row));

            }

        }

        static List<long> Pascal(List<long> row)
        {
            List<long> nextRow = new List<long>();
            nextRow.Add(1);
            for (int i = 0; i < row.Count - 1; i++)
            {
                nextRow.Add(row[i] + row[i + 1]);
            }
            nextRow.Add(1);
            return nextRow;
        }
    }
}