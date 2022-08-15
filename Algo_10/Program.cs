// UWAŻAJ NA KRÓLOWĄ
// Napisz funkcję, która rozwiązuje następujący problem:
// Mając podaną tablicę (szachową) 8 x 8 i pozycję jednej królowej, znajdź wszystkie pozycje drugiej królowej w których ta druga będzie bezpieczna.
// Przypominam, że królowa może poruszać się o dowolną ilość pul w pionie, poziomie i po przekątnych.
// W załóżeniach pomijamy istnienie jakichkolwiek innych figur na szachownicy.
// Zapraszam do zabawy!

using Algo_10;

int boardSizeX = 8;
int boardSizeY = 8;

int x = 0;
int y = 0;

try
{
    Console.WriteLine("Podaj koordynaty królowej (licząc od 0)[x y]: ");
    var response = Console.ReadLine();
    var stringCoordinates = response?.Split(" ");

    x = Int32.Parse(stringCoordinates[0]);
    y = Int32.Parse(stringCoordinates[1]);

    if (x > boardSizeX - 1 || x < 0) throw new IndexOutOfRangeException("Parametr X jest za duży");
    if (y > boardSizeY - 1 || y < 0) throw new IndexOutOfRangeException("Parametr Y jest za duży");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

var queen = new Queen(x, y, '0');

var board = new Board(boardSizeX, boardSizeY);

var boardService = new BoardService(board, queen);

boardService.RunSimulation();
boardService.DrawBoard();
