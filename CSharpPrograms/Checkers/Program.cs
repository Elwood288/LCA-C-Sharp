using System;
using System.Collections.Generic;
using System.Linq;

public struct Position
{
    public int Row { get; private set; }
    public int Column { get; private set; }
    public Position(int row, int col)
    {
        this.Row = row;
        this.Column = col;
    }
}

public enum Color { White, Black }

public class Checker
{
    public String Symbol { get; private set; }
    public Color Team { get; private set; }
    public Position Position { get; set; }

    public Checker(Color team, int row, int col)
    {
        if (team == Color.White)
        {
            Symbol = "25CB";
            Team = Color.White;

        }
        else
        {
            Symbol = "25CF";
            Team = Color.Black;
        }
    }

}

#region Class Board
public class Board
{
    public List<Checker> checkers;
    public Board()
    {
        checkers = new List<Checker>();
        for (int r = 0; r < 3; r++)
        {
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                checkers.Add(c);
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                checkers.Add(c);
            }
        }
    }

    public Checker GetChecker(Position position)
    {
        foreach (Checker c in checkers)
        {
            if (c.position.row == source.Row && c.position.Column == source.Column)
            {
                return c;
            }
        }
        return null;
    }

    public void RemoveChecker(Checker checker)
    {
        if( checker != null)
        {
            checkers.Remove(checker);
        }
        ///TODO: what is checker==null?
        //throw exception
    }

    public void MoveChecker(Checker checker, Position destination)
    {
        Checker c = new Checker(checker.Team, destination.Row, destination.Column);
        checkers.Remove(checker);
        checkers.Add(c);
    }

}
#endregion
public class Game
{
    private Board board;
    public Game()
    {
        this.board = new Board();
    }

    private bool CheckForWin()
    {
        return (board.checkers.All(x => x.Team == Color.White || board.checkers.All(x => x.Team == Color.Black));
    }

    public void Start()
    {
        // ...
    }

    public bool IsLegalMove(Color player, Position source, Position destination)
    {
        //Both the source and destination must be integers between 1 and 7
        if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7 || destination.Row < 0 ||
            destination.Row > 7 || destination.Column < 0 || destination.Column > 7) return false;
        //the destination point and the source point must fall on the same line with the slope - 1 or -1. 
        //Or the absolute value of the slope must be 1
        int rowDistance = Math.Abs(destination.Row - source.Row);
        int colDistance = Math.Abs(destination.Column - source.Column);
       

        if (colDistance == 0 || rowDistance == 0) return false;
        if (rowDistance / colDistance != 1) return false;

        //make sure the destination can only be up to two steps away from the source
        if (rowDistance > 2) return false;

        //there must be a checker at the position
        Checker c = board.GetChecker(source);
        if (c == null) return false;


        if (rowDistance == 2)
        {


            if (IsCapture(player, source, destination))
            {
                return true;
            }

            else // implies that rowDistance == 1
            {
                return false;
            }

        }
        else
        {
            return true;
        }
    }

    public bool IsCapture(Color player, Position source, Position destination)
    {
        int rowDistance = Math.Abs(destination.Row - source.Row);
        int columnDistance = Math.Abs(destination.Column - source.Column);
        if (rowDistance == 2 && columnDistance == 2)
        {
            if (rowDistance == 2)
            {
                //there must be a piece in the middle of the source and the destination
                int row_mid = (destination.Row + source.Row) / 2;
                int col_mid = (destination.Column + source.Column) / 2;
                Position p = new Position(row_mid, col_mid);
                c = board.GetChecker(p);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        //
        //int rowDistance = Math.Abs(destination.Row - source.Row);
        //int colDistance = Math.Abs(destination.Column - source.Column);
        //if (rowDistance == 2 && colDistance == 2) return true;
        //return false;
    }

    public Checker GetCaptureChecker(Color player, Position source, Position destination)
    {
        if (IsCapture(player, source, destination))
        {


            int row_mid = (destination.Row + source.Row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Position p = new Position(row_mid, col_mid);
            Checker c = board.GetChecker(p);
            return c;
        }
        else
        {
            return null;
        }
    }

    public Position ProcessInput()
    {
        Console.WriteLine("select a chekcer to move(Row, Column)");

    }

    public void DrawBoard()
    {
        String[][] grid = new String[8][];
        for (int r = 0; r < 8; r++)
        {
            grid[r] = new String[8];
            for (int c = 0; c < 8; c++)
            {
                grid[r][c] = " ";
            }
        }
        foreach (Checker c in board.checkers)
        {
            grid[c.Position.Row][c.Position.Columb] = c.Symbol;
        }

        Console.WriteLine("  0  1  2  3  4  5  6  7");
        Console.WriteLine(" ");
        for (int i = 0; i < 32; i++)
        {
            Console.WriteLine("\u2501");
        }
        for (int r = 0; r < 8; r++)
        {
            Console.Write(r);
            for (int c = 0; c < 8; c++)
            {
                Console.Write(" {0}", grid[r][c]);
            }
            Console.WriteLine();
            Console.Write(" ");

        }
    }


}

class Program
{
    public static void Main(String[] args)
    {
        Game game = new Game();
        game.Start();
    }
}


//check recording of class for help