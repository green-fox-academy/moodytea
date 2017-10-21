using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BlackJack 21 Game");

            Game game = new Game();

            game.Start();

            game.PlayersChoiceForHit();

            Console.ReadKey();
        }
    }
}