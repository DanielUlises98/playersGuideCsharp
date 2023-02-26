
using TheOldRobot;

Robot robot = new Robot();


for (int i = 0; i < robot.Commands.Length; i++)
{
    string? c = Console.ReadLine();
    switch (c)
    {
        case "on":
            robot.Commands[i] = new OnCommand();
            break;
        case "off":
            robot.Commands[i] = new OffComand();
            break;
        case "north":
            robot.Commands[i] = new NorthCommand();
            break;
        case "west":
            robot.Commands[i] = new WestCommand();
            break;
        case "east":
            robot.Commands[i] = new EastCommand();
            break;
        case "south":
            robot.Commands[i] = new SouthCommand();
            break;
        default:
            Console.WriteLine("Invalid Command");
            i--;
            break;
    }
}
robot.Run();

