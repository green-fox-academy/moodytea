﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    interface IPlayer
    {
        string GetPlayer();
        void SetPlayer(string player);
        void Play(string[,] TicTacToeBoard);
    }
}
