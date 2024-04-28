
public class GameManager
{
    private readonly Rules rules;
    private readonly Player[] players;
    private int currentPlayerIndex = 0;

    public GameManager(Rules rules, Player player1, Player player2)
    {
        this.rules = rules;
        players = new[] { player1, player2 };
    }

    public void Play(WildState wildState)
    {
        while (true)
        {
            var currentPlayer = players[currentPlayerIndex];
            GetValidMove(currentPlayer, wildState);

            wildState.Board.UpdateBoard(move.row, move.col, move.token);
            wildState.AddMove(currentPlayerIndex, move.row, move.col, move.token);
            wildState.Board.ShowBoard();

            if (rules.CheckWin((WildBoard)wildState.Board, move.token))
            {
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            SwitchPlayer();
        }
    }

    private (int row, int col, string token) move;

    private void GetValidMove(Player player, WildState wildState)
    {
        do
        {
            move = player.MakeMove((WildBoard)wildState.Board);
            if (!rules.CheckMove((WildBoard)wildState.Board, move.row, move.col, move.token))
            {
                Console.WriteLine("Invalid move, try again.");
            }
        } while (!rules.CheckMove((WildBoard)wildState.Board, move.row, move.col, move.token));
    }

    private void SwitchPlayer() => currentPlayerIndex = 1 - currentPlayerIndex;
}
