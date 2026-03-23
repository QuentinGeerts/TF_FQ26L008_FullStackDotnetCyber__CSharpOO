namespace DemoGenericite.Models;

public struct Coordonnee
{
    public Coordonnee()
    {
    }

    public Coordonnee(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }
}
