
int cityHealth = 15;
int manticoreHealth = 10;
int turn = 1;
int manticoreDistance = 0;
int canonRange = 0;

Console.ForegroundColor = ConsoleColor.Green;
CheckDistance();
int AskDistance()
{
    Console.WriteLine("How far away from the city do you want to station the Manticore?");
    return int.Parse(Console.ReadLine());
}
void CheckDistance()
{
    do
    {
        manticoreDistance = AskDistance();
        if (manticoreDistance >= 0 && manticoreDistance <= 100)
        {
            Console.Clear();
            VideoGame();
        }
        else
            Console.WriteLine("Please enter a distance in between 100 and 0");
    } while (manticoreDistance > 0);
}
void VideoGame()
{
    Console.WriteLine("Player 2 is your turn.");
    Console.WriteLine("__________________________________________________________________");
    do
    {
        Battle();
        turn++; 
        Console.WriteLine("__________________________________________________________________");
    } while (manticoreHealth>0);
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    manticoreDistance = 0;
}
void Battle()
{
    Status();
    Console.Write("Enter desired canon range: ");
    canonRange = int.Parse(Console.ReadLine());
    ExpectedDamage(canonRange);
}

void ExpectedDamage(int canonRange)
{
    if (turn % 3 == 0 && turn % 5 == 0)
    {
        DamageOutput(10);
        Attack(canonRange,10);
    }
    else if (turn % 3 == 0 || turn % 5 == 0)
    {
        DamageOutput(3);
        Attack(canonRange,3);
    } else if(turn == 1)
    {
        DamageOutput(1);
        Attack(canonRange, 1);
    }
    else
    {
        DamageOutput(1);
        Attack(canonRange,1);
    }
}
void Attack(int canonRange,int damage)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (canonRange == manticoreDistance)
    {
        Console.WriteLine("That round was a Direct HIT!");
        DamageManticoreHealth(damage);
        Console.Beep();
    }else if (canonRange < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target");
        DamageCityHealth();
    }else { 
        Console.WriteLine("That round OVERSHOT the target");
        DamageCityHealth();
    }
}
void DamageCityHealth()
{
    cityHealth--;
}
void DamageManticoreHealth(int damage)
{
    manticoreHealth-=damage;
}
void DamageOutput(int damage)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"The canon is expected to deal {damage} this round");
}
void Status()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"STATUS: Round:{turn} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
}