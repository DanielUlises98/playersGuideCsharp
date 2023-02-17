

using RockPaperScissors;

Console.WriteLine("Player One name: ");
string? pOneName = Console.ReadLine();
Player playerOne = new Player(pOneName);

Console.WriteLine("Player Two name: ");
string? pTwoName = Console.ReadLine();
Player playerTwo = new Player(pTwoName);

Player[] players = new Player[] {playerOne,playerTwo};

Game game = new();
game.Players = players;


while (true)
{
    Console.WriteLine($"{pOneName} Chose Rock Paper or Scissors");

    RPS rpsChoiceOne = new RPS();
    DetermineChoice(Console.ReadLine(), rpsChoiceOne);

    Console.WriteLine($"{pTwoName} Chose Rock Paper or Scissors");

    RPS rpsChoiceTwo = new RPS();
    DetermineChoice(Console.ReadLine(), rpsChoiceTwo);

    RPS[] rrps = new RPS[] { rpsChoiceOne, rpsChoiceTwo };
    game.Rps= rrps;

    game.WhoWins();
    for (int i = 0; i <= 1; i++)
    {
        Console.WriteLine($"Player {game.Players[i].UserName} has won {game.Players[i].Wins()} times");
        Console.WriteLine($"There have been this many draws in the game; {game.GetDraws}");

    }

}
void DetermineChoice(string choice,RPS rps)
{
    switch (choice)
    {
        case "Rock":
            rps.SetRpsChoice(RPSenum.Rock);
            break;
        case "Paper":
            rps.SetRpsChoice(RPSenum.Paper);
            break;
        case "Scissors":
            rps.SetRpsChoice(RPSenum.Scissors);
            break;
    }
}


class Game
{
    public Player[] Players { get; set; }
    public RPS[] Rps { get; set; }
    private int Draws { get; set; }

    public int GetDraws() { return Draws; }
    
    public void WhoWins()
    {
        if (Rps[0].GetRpsChoice == Rps[1].GetRpsChoice)
        {
            Draws++;
            Console.WriteLine($"It's a draw");
            return;
        }
        if (Math.Abs((int)Rps[0].GetRpsChoice - (int)Rps[1].GetRpsChoice) == 2){
            if (Rps[0].GetRpsChoice == 0)
            {
                Console.WriteLine($"{Players[1].UserName} Wins");
                Players[1].Won();
            }
            else
            {
                Console.WriteLine($"{Players[0].UserName} Wins");
                Players[0].Won();
            }
            return;
        }
        if (Rps[0].GetRpsChoice > Rps[1].GetRpsChoice)
        {
            Console.WriteLine($"{Players[0].UserName} Wins");
            Players[0].Won();
        }
        else { Console.WriteLine($"{Players[1].UserName} Wins");
                Players[1].Won();
        }
    }
}