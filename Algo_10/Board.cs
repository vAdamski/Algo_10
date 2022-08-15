namespace Algo_10;

public class Board
{
    public int MaxSize { get; private set; }
    public char[,] board { get; private set; }

    public Board(int sizeX, int sizeY)
    {
        board = new char[sizeX, sizeY];
        MaxSize = sizeX >= sizeY ? sizeX : sizeY;
    }
}