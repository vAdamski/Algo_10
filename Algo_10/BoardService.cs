namespace Algo_10;

public class BoardService
{
    private readonly Queen _queen;
    private Board _board { get; set; }

    public BoardService(Board board, Queen queen)
    {
        _queen = queen;
        _board = board;
    }
    
    public void RunSimulation()
    {
        FillBoard();
        DrawQueenMovementOnBoard();
    }

    private void FillBoard()
    {
        for (int i = 0; i < _board.board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.board.GetLength(1); j++)
            {
                _board.board[i, j] = '#';
            }
        }
    }

    private void DrawQueenMovementOnBoard()
    {
        int x = _queen.X;
        int y = _queen.Y;
        char queenSign = _queen.Sign;
        
        for (int i = 0; i < _board.MaxSize; i++)
        {
            if (i < _board.board.GetLength(0)) _board.board[i, y] = queenSign;
            if (i < _board.board.GetLength(1)) _board.board[x, i] = queenSign;
            if (x + i < _board.board.GetLength(0) && y + i < _board.board.GetLength(1)) _board.board[x + i, y + i] = queenSign;
            if (x - i >= 0 && y - i >= 0) _board.board[x - i, y - i] = queenSign;
            if (x - i >= 0 && y + i < _board.board.GetLength(1)) _board.board[x - i, y + i] = queenSign;
            if (x + i < _board.board.GetLength(0) && y - i >= 0) _board.board[x + i, y - i] = queenSign;
        }
    }

    public void DrawBoard()
    {
        for (int i = 0; i < _board.board.GetLength(0); i++)
        {
            for (int j = 0; j < _board.board.GetLength(1); j++)
            {
                Console.Write($"{_board.board[i,j]} ");
            }
            Console.Write('\n');
        }
    }
}