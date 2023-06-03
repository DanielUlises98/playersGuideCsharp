
//ConsoleColor background = Console.BackgroundColor;
using System.Drawing;

ColoredItem<Sword> a = new(new Sword(),ConsoleColor.Red);
ColoredItem<Bow> b = new(new Bow(), ConsoleColor.Green);
ColoredItem<Axe> c = new(new Axe(), ConsoleColor.Blue);

a.Display();
b.Display();
c.Display();


public class Sword{ }
public class Bow { }
public class Axe { }
public class ColoredItem<T> 
{
    private ConsoleColor backGroundColor { get; init; }
    public T Item { get;}
    public ColoredItem(T item, ConsoleColor color)
    {
        backGroundColor = color;
        Item = item;
    }
    public void Display()
    {
        Console.BackgroundColor = backGroundColor;
        Console.WriteLine(Item);

    }
}