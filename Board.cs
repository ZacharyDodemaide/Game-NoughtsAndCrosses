
using static Constants;
public interface Board
{
    void Setup();
    void UpdateBoard(int row, int col, string playerSymbol);
    void ShowBoard();
}

public class WildBoard : Board
{
    private string[,] board;
    public string[,] Board
    {
        get
        {
            return board;
        }
    }

    public WildBoard()
    {
        board = new string[board_size, board_size];
        Setup();
    }
    public void Setup()
    {
        for (int row = first_index; row < board_size; row++)
        {
            for (int col = first_index; col < board_size; col++)
            {
                board[row, col] = empty_cell;
            }
        }
    }

    public void UpdateBoard(int row, int col, string token)
    {
        board[row, col] = token;
    }

    public void ShowBoard()
    {
        for (int row = first_index; row < board_size; row++)
        {
            for (int col = first_index; col < board_size; col++)
            {
                string cell = board[row, col];
                if (cell == X || cell == O)
                {
                    Console.Write(cell);
                }
                else
                {
                    Console.Write(empty_cell);
                }
                if (col < last_index)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (row < last_index)
            {
                Console.WriteLine("---+---+---");
            }
        }
    }
}




