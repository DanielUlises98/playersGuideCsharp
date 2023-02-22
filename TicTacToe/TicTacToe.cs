namespace TicTacToe
{
    public class TTT
    {
        private char[] _ttt = new char[9];
        
        public void Choose(int selection, char player)
        {
            if (IsAlreadyTaken(selection))
            {
                Console.WriteLine("The position you're trying to choose is already taken");
                Console.WriteLine("Press any Key to continue");
                Console.ReadKey();
            }
            else
                _ttt[selection - 1] = player;

            WhoWon(player);
        }

        private bool IsAlreadyTaken(int selection)
        {
            if (_ttt[selection - 1] == 'O' || _ttt[selection - 1] == 'X') return true;
            return false;
        }

        public void DrawScenary()
        {
            Console.WriteLine($" {_ttt[6]} | {_ttt[7]} | {_ttt[8]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {_ttt[3]} | {_ttt[4]} | {_ttt[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {_ttt[0]} | {_ttt[1]} | {_ttt[2]}");
        }

        private void WhoWon(char player)
        {
            if (_ttt[0] == _ttt[4] && _ttt[0] == _ttt[8] && _ttt[0] != '\0')
            {
                Console.WriteLine($"Player {player} won");
                return;
            }

            if (_ttt[2] == _ttt[4] && _ttt[2] == _ttt[6] && _ttt[0] != '\0')
            {
                Console.WriteLine($"Player {player} won");
                return;
            }
            for (int i = 0,j=0; i <=3; i++,j+=3)
            {
                if (_ttt[j] == _ttt[j + 1] && _ttt[j] == _ttt[j + 2] && _ttt[j] != '\0')
                {
                    Console.WriteLine($"Player {player} won");
                    return;
                }

                if (_ttt[i] == _ttt[i + 3] && _ttt[i] == _ttt[i + 6] && _ttt[i] != '\0')
                {
                    Console.WriteLine($"Player {player} won");
                    return;
                }
            }
        }
    }
}

