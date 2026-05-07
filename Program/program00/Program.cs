using ChessGameClass;

namespace program00
{

    public class Program
    {

        public static void Main()
        {

            Chess board = new Chess();

            int fromRow;
            int fromCol;
            int toRow;
            int toCol;


            bool running = true;

            Console.WriteLine("\nWelcome to Chess in C#!\n");

            Console.WriteLine("──────────── RULES ────────────");
            Console.WriteLine("• White moves first");
            Console.WriteLine("• Each player moves one piece per turn");
            Console.WriteLine("• Capture the enemy King to win\n");
            Console.WriteLine("• Enter anything different than a number tp quit the game\n");

            Console.WriteLine("BOARD:");
            board.Draw();

            while (running)
            {

                try
                {

                    Console.WriteLine("\nFrom Row: ");
                    fromRow = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nFrom Column: ");
                    fromCol = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nTo Row: ");
                    toRow = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nTo Column: ");
                    toCol = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    bool validmove = board.Move(fromRow, fromCol, toRow, toCol);

                    if (!validmove)
                    {
                        Console.WriteLine("Invalid Move!\n");
                    }

                    board.Move(fromRow, fromCol, toRow, toCol);

                    board.Draw();
                }
                catch
                {

                    Console.WriteLine("\nQuitting game...");
                    break;
                }


            }


        }
    }
}