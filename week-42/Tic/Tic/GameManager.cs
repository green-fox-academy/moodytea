using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    class GameManager
    {
        private readonly GameVisualizer gameVisualizer;
        private readonly GameEngine gameEngine;

        public GameManager(GameVisualizer arggameVisualizer, GameEngine arggameEngine)
        {
            gameVisualizer = arggameVisualizer;
            gameEngine = arggameEngine;
        }

        public void PlayGame(string[,] TicTacToeBoard, IPlayer player1, IPlayer player2)
        {
            gameVisualizer.InitalizeBoard(TicTacToeBoard);

            Console.WriteLine("Player One, do you want to be X or O?");
            while (true)
            {
                var player1Name = Console.ReadLine().ToUpper();

                if (player1Name.ToUpper().Equals("X") || player1Name.ToUpper().Equals("O"))
                {
                    player1.SetPlayer(player1Name);
                    break;
                }
            }

            player2.SetPlayer(player1.GetPlayer().ToUpper().Equals("X") ? "O" : "X");

            var Winner = string.Empty;
            var currentPlayer = player1;

            while (Winner.Equals(string.Empty))
            {
                player1.Play(TicTacToeBoard);
                player2.Play(TicTacToeBoard);

                gameVisualizer.PrintTicTacToeBoard(TicTacToeBoard);

                Winner = gameEngine.CheckForVictory(TicTacToeBoard, currentPlayer.GetPlayer());

                currentPlayer = currentPlayer.Equals(player1) ? player2 : player1;
            }

            Console.WriteLine($"The winner is: {0}", Winner);
        }
    }
}
