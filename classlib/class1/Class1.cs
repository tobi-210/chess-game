
namespace ChessGameClass;

public class ChessFigure
{
}

public class Chess
{

    public char[,] board = new char[8, 8];

    public Chess()
    {
        // Bauern

        for (int i = 0; i < 8; i++)
        {
            board[1, i] = '♙';
            board[6, i] = '♟';
        }

        // Türme

        board[0, 0] = board[0, 7] = '♖';
        board[7, 0] = board[7, 7] = '♜';


        // Pferde

        board[0, 1] = board[0, 6] = '♘';
        board[7, 1] = board[7, 6] = '♞';


        // Läufer

        board[0, 2] = board[0, 5] = '♗';
        board[7, 2] = board[7, 5] = '♝';


        // Königin

        board[0, 4] = '♕';
        board[7, 4] = '♛';


        // König

        board[0, 3] = '♔';
        board[7, 3] = '♚';

    }

    // ############### SPIELFELD ###############
    public void Draw()
    {
        int size = 8;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                bool isWhite = (row + col) % 2 == 0;

                Console.BackgroundColor = isWhite
                    ? ConsoleColor.White
                    : ConsoleColor.DarkGray;

                char figure = board[row, col];

                if (figure != '\0')
                {

                    Console.Write($"{figure} ");
                }
                else
                {
                    Console.Write("  ");
                }

                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }

    // ############### FIGUR-BEWEGUNG ###############

    public bool Move(int fromRow, int fromCol, int toRow, int toCol)
    {

        if (fromRow < 0 || fromRow >= 8 || fromCol < 0 || fromCol >= 8)
        {
            return false;
        }

        if (toRow < 0 || toRow >= 8 || toCol < 0 || toCol >= 8)
        {
            return false;
        }

        char piece = board[fromRow, fromCol];

        if (piece == '\0')
        {
            return false;
        }


            board[toRow, toCol] = piece;
            board[fromRow, fromCol] = '\0';

            return true;


    }
}