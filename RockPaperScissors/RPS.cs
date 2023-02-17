using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RPS
    {
        private RPSenum RpsChoice { get; set; }


        public void SetRpsChoice(RPSenum rpsChoice) => RpsChoice = rpsChoice;
        public RPSenum GetRpsChoice => RpsChoice;

    }
    enum RPSenum
    {
        Rock,
        Scissors,
        Paper
    }
}
