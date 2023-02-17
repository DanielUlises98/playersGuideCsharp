using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Player
    {
        public string UserName { get; }
        private int Win { get; set; }

        public Player(string userName)
        {
            UserName = userName;
        }
        public void Won() { Win++; }
        public int Wins() => Win;
    }
}
