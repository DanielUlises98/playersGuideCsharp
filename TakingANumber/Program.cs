
Console.WriteLine(AskFornumber("What is the airspeed velocity of an unladen swallow?"));
int AskFornumber(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
int range = AskForNumberInRange("Please insert a number ",5,10);
int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine($"{text} in between {min} and {max}");
    int number = int.Parse(Console.ReadLine());
    while (number < max && number >min)
    {
        return number;
    }
    return 0;
}