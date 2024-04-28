
using static Constants;

public interface Rules
{
    bool CheckMove(WildBoard wildBoard, int row, int col, string token);
    bool CheckWin(WildBoard wildBoard, string token);
}
public class WildRules : Rules
{
    // A method that checks the validity of a move
    public bool CheckMove(WildBoard wildBoard, int row, int col, string token)
    {
        // Access the board field of the wildBoard object using the property
        string[,] board = wildBoard.Board;

        // Check if the row and col are within the range of the board
        if (row < first_index || row > last_index || col < first_index || col > last_index)
        {
            return false;
        }

        // Check if the board cell is empty
        if (board[row, col] != "   ")
        {
            return false;
        }

        // Check if the token is valid
        if (token != X && token != O)
        {
            return false;
        }

        // If all the checks pass, return true
        return true;
    }

    public bool CheckWin(WildBoard wildBoard, string token)
    {
        string[,] board = wildBoard.Board;

        // Check rows
        for (int row = first_index; row < board_size; row++)
        {
            for (int col = first_index; col < board_size; col++)
            {
                if (board[row, col] != token)
                {
                    break;
                }
                if (col == last_index)
                {
                    return true;
                }
            }
        }
        // Check columns
        for (int col = first_index; col < board_size; col++)
        {
            for (int row = first_index; row < board_size; row++)
            {
                if (board[row, col] != token)
                {
                    break;
                }
                if (row == last_index)
                {
                    return true;
                }
            }
        }
        // Check 1st diagonal - top left > bottom right
        for (int row = first_index; row < board_size; row++)
        {
            if (board[row, row] != token)
            {
                break;
            }
            if (row == last_index)
            {
                return true;
            }
        }
        // Check 2nd diagonal - bottom left > top right
        for (int row = first_index; row < board_size; row++)
        {
            if (board[row, last_index - row] != token)
            {
                break;
            }
            if (row == last_index)
            {
                return true;
            }
        }
        // If no win condition is found return false
        return false;
    }
}
