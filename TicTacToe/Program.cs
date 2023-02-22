using TicTacToe;

TTT t = new TTT();
int i = 0;
char currentPlayer = 'O';
do
{
    Console.WriteLine($"Player \"{currentPlayer}\" choose position");
    t.DrawScenary();
    int selection = int.Parse(Console.ReadLine());
    t.Choose(selection,currentPlayer);
    Console.Clear();
    currentPlayer = WhoPlayer(currentPlayer);
    i++;
}while(i<9);


char WhoPlayer(char player)
{
    if (player == 'O')
        return 'X';
    return 'O';
}