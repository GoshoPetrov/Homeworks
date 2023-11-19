namespace Pokemon_Dont_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (pokemons.Count >0)
            {
                int whoToRemove = int.Parse(Console.ReadLine());

                bool copyLast = false;
                if (whoToRemove < 0)
                {
                    copyLast = true;
                    whoToRemove = 0;
                }

                bool copyFirst = false;
                if (whoToRemove > pokemons.Count -1)
                {
                    copyFirst = true;
                    whoToRemove = pokemons.Count - 1;
                }

                int pok = pokemons[whoToRemove];
                sum += pok;

                if (copyFirst || copyLast)
                {

                }
                else
                {
                    pokemons.RemoveAt(whoToRemove);
                }

                for (int i=0; i<pokemons.Count; i++)
                {
                    if (pokemons[i] <= pok)
                    {
                        pokemons[i] += pok;
                    } 
                    else
                    {
                        pokemons[i] -= pok;
                    }
                }

                if (copyLast && pokemons.Count > 0)
                {
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }

                if (copyFirst && pokemons.Count > 0)
                {
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
            }

            Console.WriteLine(sum);
        }
    }
}