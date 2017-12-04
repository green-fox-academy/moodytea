using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    class GameVisualizer
    {
        public void InitalizeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    ticTacToeBoard[i, j] = " ";
                }
            }
        }

        public void PrintTicTacToeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    Console.Write(ticTacToeBoard[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
