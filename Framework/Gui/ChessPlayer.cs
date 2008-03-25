﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UvsChess
{

    // Students don't need to see this class
    class ChessPlayer
    {
        public ChessColor Color;
        public string AIName;
        public IChessAI AI;

        public ChessPlayer(ChessColor color)
        {
            Color = color;
        }
        public bool IsHuman
        {
            get { return AI == null; }
        }
        public bool IsComputer
        {
            get { return !IsHuman; }
        }
    }

    // Students don't need to see this class
    class AI
    {
        public string FullName;
        public string ShortName;
        public string FileName;

        public AI(string shortName)
        {
            ShortName = shortName;
        }
    }

}