namespace Algo_10;

public class Board
{
    private readonly int _maxSize;
    private readonly char[,] _board;
    private readonly Queen _queen;

    public Board(int sizeX, int sizeY, Queen queen)
    {
        _queen = queen;

        _board = new char[sizeX, sizeY];
        
        _maxSize = sizeX >= sizeY ? sizeX : sizeY;
    }

    public void RunSimulation()
    {
        FillBoard();
        DrawQueenMovementOnBoard();
    }

    private void FillBoard()
    {
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                _board[i, j] = '#';
            }
        }
    }

    private void DrawQueenMovementOnBoard()
    {
        int x = _queen.X;
        int y = _queen.Y;
        char queenSign = _queen.Sign;
        
        for (int i = 0; i < _maxSize; i++)
        {
            if (i < _board.GetLength(0)) _board[i, y] = queenSign;
            if (i < _board.GetLength(1)) _board[x, i] = queenSign;
            if (x + i < _board.GetLength(0) && y + i < _board.GetLength(1)) _board[x + i, y + i] = queenSign;
            if (x - i >= 0 && y - i >= 0) _board[x - i, y - i] = queenSign;
            if (x - i >= 0 && y + i < _board.GetLength(1)) _board[x - i, y + i] = queenSign;
            if (x + i < _board.GetLength(0) && y - i >= 0) _board[x + i, y - i] = queenSign;
        }
    }

    public void DrawBoard()
    {
        for (int i = 0; i < _board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.GetLength(1); j++)
            {
                Console.Write($"{_board[i,j]} ");
            }
            Console.Write('\n');
        }
    }
}