using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TTT
    {
        private char[] ticTacToe = new char[9];
        public void DrawScenary()
        {
            Console.WriteLine(" ");
            WhoWon();
        }
        public void Choose(int selection, int player)
        {
            switch(selection)
            {
                case 1:
                    AsignValue(selection, player);
                    break;
                case 2:
                    AsignValue(selection, player);
                    break;
                case 3:
                    AsignValue(selection, player);
                    break;
                case 4:
                    AsignValue(selection, player);
                    break;
                case 5:
                    AsignValue(selection, player);
                    break;
                case 6:
                    AsignValue(selection, player);
                    break;
                case 7:
                    AsignValue(selection, player);
                    break;
                case 8:
                    AsignValue(selection, player);
                    break;
                case 9:
                    AsignValue(selection, player);
                    break;
            }
        }

        private void AsignValue(int selection, int player)
        {
            if (IsAlreadyTaken(selection))
            {
                Console.WriteLine("The position you are trying to write on is alredy taken");
                return;
            }
            ticTacToe[selection-1] = whoChose(player);
        }
        private char whoChose(int player)
        {
            return player == 0 ? 'X' : '0';
        }
        private bool IsAlreadyTaken(int selection)
        {
            if (ticTacToe[selection - 1] != (char)0) return true;
            return false;
        }
        private void WhoWon()
        {
            for(int i = 0, j = 0; i <= 3; i++, j += 3)
            {
                if (ticTacToe[j] == ticTacToe[i+1] && ticTacToe[i+1] == ticTacToe[i+2]) {
                    Console.WriteLine("Player One wone");
                    return;
                }
                if(ticTacToe[j] == ticTacToe[i + 3] && ticTacToe[i + 6] == ticTacToe[i + 3])
                {
                    Console.WriteLine("Player Wone");
                    return;
                }
            }
        }
        
    }
}
