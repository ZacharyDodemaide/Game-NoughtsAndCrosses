
using static Constants;

public interface Player
{
    (int row, int col, string token) MakeMove(WildBoard board);
}

public class HumanPlayer : Player
{
    public HumanPlayer()
    {
        WildBoard wildBoard = new WildBoard();
    }
    public (int row, int col, string token) MakeMove(WildBoard board)
    {
        Console.WriteLine("Enter row,column,token (0,0,x)");

        string[] input = Console.ReadLine().Split(',');
        try
        {
            if (input.Length >= 3)
            {
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);
                string token = input[2].ToUpper();
                if (token == "X")
                {
                    token = X;
                }
                else if (token == "O")
                {
                    token = O;
                }
                return (row, col, token);
            }
            else
            {
                return (99, 99, "");
            }
        }
        catch (FormatException)
        {
            return (99, 99, "");
        }
    }
}

public class MachinePlayer : Player
{
    private Random random = new Random();


    public (int row, int col, string token) MakeMove(WildBoard board)
    {
        int row, col;
        string token;
        do
        {
            row = random.Next(first_index, 3);
            col = random.Next(first_index, board_size);
            token = random.Next(first_index, last_index) == first_index ? X : O;
        } while (board.Board[row, col] != "   ");
        return (row, col, token);
    }
}
