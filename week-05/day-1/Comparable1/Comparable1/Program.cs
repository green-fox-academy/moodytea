using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable1
{
    class Program
    {
        public static List<Domino> dominoes = InitializeDominoes();
        static void Main(string[] args)
        {
            
            Console.WriteLine(dominoes);
            dominoes.Sort();

            
            Console.ReadKey();

            for (Domino d : dominoes)
            {
                d.PrintAllFields();
            }
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
