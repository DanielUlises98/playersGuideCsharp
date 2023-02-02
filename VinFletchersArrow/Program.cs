// See https://aka.ms/new-console-template for more information
do
{
    ArrowHead head;
    Fletching tail;
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Choose arrow head, 1: steel, 2: wood, 3: obsidian");
    head = (ArrowHead)int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine("Choose arrow fletching, 1: plastic, 2: turkey feathers, 3: goose feathers");
    tail = (Fletching)int.Parse(Console.ReadLine()) - 1;
    Console.WriteLine("Chosse the lenght of the shaft?");
    float lenght = float.Parse(Console.ReadLine());
    if (lenght >= 60 || lenght <= 100)
    {
        Arrow arr = new Arrow(head, lenght, tail);
        Console.WriteLine($"The price of the arrow is ${arr.GetCost()}");
    }
} while (true);

class Arrow
{
    public float shaftLenght;
    public ArrowHead head;
    public Fletching tail;
    private float arrowHeadPrice;
    private float tailPrice;
    public Arrow(ArrowHead head, float shaftLenght, Fletching tail)
    {   
        this.head = head;
        this.tail = tail;
        this.shaftLenght = shaftLenght;

        if (head == 0)
        {
            arrowHeadPrice = 10;
        }
        else if (head == (ArrowHead)1)
        {
            arrowHeadPrice = 3;
        }
        else
            arrowHeadPrice = 5;

        if (tail == 0)
        {
            tailPrice = 10;
        }else if (tail == (Fletching)1) {
            tailPrice = 5;
        }else
            tailPrice = 3;


    }
    public float GetCost() => (arrowHeadPrice + tailPrice) + (shaftLenght * 0.05f);
}

enum ArrowHead{
    Steel,
    Wood,
    Obsidian
}
enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}