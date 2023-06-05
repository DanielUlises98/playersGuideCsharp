﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects
{
    internal class Game
    {
        public World worldGame { get; set; }
        public Game(World worldGame)
        {
            this.worldGame = worldGame;
        }
        public void Start()
        {
            worldGame.CreateWorld();
        }
    }
}
