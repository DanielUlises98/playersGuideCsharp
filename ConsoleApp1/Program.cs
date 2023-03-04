

Coordinate coordinate = new Coordinate(4,4);
Coordinate coordinate2 = new Coordinate(5,5);
if (coordinate.AreTheyClose(coordinate2))
    Console.WriteLine("Coordinates are close");
public struct Coordinate
{
    private readonly int x;
    private readonly int y;


    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public bool AreTheyClose(Coordinate cordinate)
    {
        int absX = Math.Abs(cordinate.x - x);
        int absY = Math.Abs(cordinate.y - y);

        if (absX == 1 || absX < 1 && absY == 1 || absY < 1)
            return true;
        return false;
    }
}