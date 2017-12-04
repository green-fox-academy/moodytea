using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    class RealPlayer : IPlayer
    {
        private string player;

        public string GetPlayer()
        {
            return player;
        }

        public void Play(string[,] TicTacToeBoard)
        {
            Console.WriteLine("Enter position X for {0}", player);
            int positionX = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter position Y for {1}", player);
            int positionY = Int32.Parse(Console.ReadLine());

            if (TicTacToeBoard[positionX, positionY].Equals(" ")) TicTacToeBoard[positionX, positionY] = player;

        }

        public void SetPlayer(string player)
        {
            this.player = player;
        }
    }
}
