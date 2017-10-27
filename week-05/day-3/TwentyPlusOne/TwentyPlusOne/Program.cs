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
            Console.WriteLine("Welcome to the awesomest BlackJack 21 Game");
            string divider = "-------------------------------------------";
            Console.WriteLine(divider);
            Console.WriteLine(divider);

            Game game = new Game();
            
            game.Start();
        }
    }
}