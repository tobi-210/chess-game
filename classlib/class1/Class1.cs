namespace ChessGameClass;

public class ChessFigure
{

}

public class Chess
{

    // =================== SPIELFELD ==================
    public override string ToString()
    {

        var sb = new System.Text.StringBuilder();
        int size = 8;

        string line = "+";
        for (int i = 0; i < size; i++)
            // somit kann dynamisch die Größe des Feldes gesetzt werden
            line += "--+";

        for (int row = 0; row < size; row++)
        {
            sb.AppendLine(line);

            for (int col = 0; col < size; col++)
            {
                sb.Append("|");

                if ((row + col) % 2 == 0) // jedes zweite Feld soll weiß sein

                    sb.Append("##"); // weißes Feld
                else
                    sb.Append("  "); // schwarzes Feld
            }

            sb.AppendLine("|");
        }

        sb.AppendLine(line);

        return sb.ToString();
    }

    // ================================================



    
}


