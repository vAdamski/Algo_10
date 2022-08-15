namespace Algo_10;

public class Queen
{
    public char Sign { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Queen(int x, int y, char sign)
    {
        X = x;
        Y = y;
        Sign = sign;
    }
}