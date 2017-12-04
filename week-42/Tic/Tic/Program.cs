using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string[,] TicTacToeBoard = new string[3, 3];

            GameEngine gameEngine = new GameEngine();
            GameVisualizer gameVisualizer = new GameVisualizer();
            GameManager gameManager = new GameManager(gameVisualizer, gameEngine);

            IPlayer player1;
            IPlayer player2;

            //while (true)
            //{
            //    Console.WriteLine("Chose Player Mode: 2PLAYER or AI?");
            //    var mode = Console.ReadLine().ToUpper();
            //    if (mode.Equals("2PLAYER"))
            //    {
            //        player1 = new RealPlayer();
            //        player2 = new RealPlayer();
            //        break;
            //    }
            //    else if (mode.Equals("AI"))
            //    {
            //        player1 = new RealPlayer();
            //        player2 = new AIPlayer();
            //        break;
            //    }
            //}
            //gameManager.PlayGame(TicTacToeBoard, player1, player2);
        }
    }
}
