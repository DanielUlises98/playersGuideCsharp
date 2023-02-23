using TicTacToe;

TTT t = new TTT();
int i = 0;
char currentPlayer = 'O';
do
{

    Drawer();
    int selection = int.Parse(Console.ReadLine());
    t.Choose(selection, currentPlayer);
    if (t.WhoWon(currentPlayer))
    {
        Drawer();
        break;
    }
    currentPlayer = WhoPlayer(currentPlayer);
    i++;
}while(i<9);
Console.WriteLine("Draw/Cat");

char WhoPlayer(char player)
{
    if (player == 'O')
        return 'X';
    return 'O';
}
void Drawer()
{
    Console.Clear();
    Console.WriteLine($"Player \"{currentPlayer}\" choose position");
    t.DrawScenary();
}