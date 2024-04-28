
public class Setup
{
    public static void Main(string[] args)
    {
        // Create the game components
        WildBoard wildBoard = new WildBoard();
        WildState wildState = new WildState(wildBoard);

        WildRules rules = new WildRules();
        HumanPlayer player1 = new HumanPlayer();
        MachinePlayer player2 = new MachinePlayer();

        // Start and manage the game
        GameManager gameManager = new GameManager(rules, player1, player2);
        gameManager.Play(wildState);


        wildBoard.ShowBoard();

        Console.ReadKey();
    }
}
