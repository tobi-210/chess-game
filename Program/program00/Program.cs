using ChessGameClass;

namespace ChessGameProgram
{

    public class Program
    {

        public static void Main()
        {

            Chess board = new Chess();

            Console.WriteLine();
            board.Draw();

             // (y, x) 
            
            board.MoveBauer(1, 1, 2, 1); // 1, 0 in dem Fall Startposition

            Console.WriteLine("\nNach Zug:\n");

            board.Draw();

        }
    }
}