// See https://aka.ms/new-console-template for more information
do
{

    Console.WriteLine("Press 1 for Elite Arrow, 2 for Begginer Arrow, 3 Marksman arrowm, 4 for custom Arrow");
    int arrowChoice = int.Parse(Console.ReadLine());
    switch (arrowChoice)
    {
        case 1:
            CustomArrow(0,95,0);
            break;
        case 2:
            CustomArrow((ArrowHead)1, 75, (Fletching)1);
            break;
        case 3:
            CustomArrow(0, 65, (Fletching)1);
            break;
        case 4:
            ArrowHead head;
            Fletching tail;
            float lenght;
            Console.WriteLine("Choose arrow head, 1: steel, 2: wood, 3: obsidian");
            head = (ArrowHead)int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Choose arrow fletching, 1: plastic, 2: turkey feathers, 3: goose feathers");
            tail = (Fletching)int.Parse(Console.ReadLine()) - 1;
            do
            {
                Console.WriteLine("Chosse the lenght of the shaft?(In the range of 60 up to 100)");
                lenght = float.Parse(Console.ReadLine());
            }
            while (lenght <= 60 || lenght >= 100);
            Arrow arr = new Arrow(head, lenght, tail);
            ArrowPrice(arr);
            break;
        default:
            Console.WriteLine("Please choose a valid options in the range of 1 to 4");
            break;
    }

} while (true);

void CustomArrow(ArrowHead head, float lenght, Fletching tail)
{
    Arrow arrow = Arrow.CreateEliteArrow(head, lenght, tail);
    ArrowPrice(arrow);
}
void ArrowPrice(Arrow arr)
{
    Console.WriteLine($"The price of the arrow is ${arr.GetCost()}");
}
class Arrow
{
    public float ShaftLenght { get; set; }
    public ArrowHead Head { get; set; }
    public Fletching Fletching { get; set; }
    public float ArrowHeadPrice { get; set; }
    public float TailPrice { get; set; }
    public float GetCost() => (ArrowHeadPrice + TailPrice) + (ShaftLenght * 0.05f);

    public Arrow(ArrowHead head, float shaftLenght, Fletching tail)
    {   
        Head = head;
        Fletching = tail;
        ShaftLenght = shaftLenght;
        InitProperties(head, tail);
    }

    public static Arrow CreateEliteArrow(ArrowHead head,float shaftLenght, Fletching tail) => new Arrow(head,shaftLenght, tail);
    public static Arrow CreateBegginerArrow(ArrowHead head,float shaftLenght, Fletching tail) => new Arrow(head,shaftLenght, tail);
    public static Arrow CreateMarksmanArrow(ArrowHead head, float shaftLenght, Fletching tail) => new Arrow(head, shaftLenght, tail);

    public void InitProperties(ArrowHead head, Fletching tail)
    {
        if (head == 0)
        {
            ArrowHeadPrice = 10;
        }
        else if (head == (ArrowHead)1)
        {
            ArrowHeadPrice = 3;
        }
        else
            ArrowHeadPrice = 5;

        if (tail == 0)
        {
            TailPrice = 10;
        }
        else if (tail == (Fletching)1)
        {
            TailPrice = 5;
        }
        else
            TailPrice = 3;
    }
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