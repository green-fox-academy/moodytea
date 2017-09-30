using System;
using System.Collections.Generic;

namespace Domino
{
	public class Dominoes
	{
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            int j = 0;
            Console.Write("[" + dominoes[0].GetValues()[0]+", " + dominoes[0].GetValues()[1] + "], ");
            int k = dominoes[0].GetValues()[1];
            for (int i = 0; i < dominoes.Count - 1; i++)
            {
                j = 1;
                while (j <= dominoes.Count - 1 && dominoes[j].GetValues()[0] != k)
                {
                    j++;
                }
                Console.Write("[" + dominoes[j].GetValues()[0] + ", " + dominoes[j].GetValues()[1] + "], ");
                k = dominoes[j].GetValues()[1];
            }
            Console.ReadKey();
        }

        public static List<Domino> InitializeDominoes()
		{
			var dominoes = new List<Domino>();
			dominoes.Add(new Domino(5, 2));
			dominoes.Add(new Domino(4, 6));
			dominoes.Add(new Domino(1, 5));
			dominoes.Add(new Domino(6, 7));
			dominoes.Add(new Domino(2, 4));
			dominoes.Add(new Domino(7, 1));
            dominoes.ToArray();

			return dominoes;
		}
		
	}
}