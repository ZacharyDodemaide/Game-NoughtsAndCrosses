
public interface GameState
{
    Board Board { get; set; }
    Stack<string> MoveHistory { get; set; }
    Stack<string> RedoMoveHistory { get; set; }

}

public class WildState : GameState
{
    public Board Board { get; set; }
    public Stack<string> MoveHistory { get; set; }
    public Stack<string> RedoMoveHistory { get; set; }

    public WildState(WildBoard wb)
    {
        Board = wb;
        MoveHistory = new Stack<string>();
        RedoMoveHistory = new Stack<string>();
    }
    public void AddMove(int player, int row, int col, string token)
    {
        MoveHistory.Push($"Player: {player}, Row: {row}, Col: {col}, Token: {token}");
        RedoMoveHistory.Clear();
    }
    public string UndoMove()
    {
        if (MoveHistory.Count > 0)
        {
            string lastMove = MoveHistory.Pop();
            RedoMoveHistory.Push(lastMove);
            return lastMove;
        }
        return null;
    }

    public string RedoMove()
    {
        if (RedoMoveHistory.Count > 0)
        {
            string lastUndoneMove = RedoMoveHistory.Pop();
            MoveHistory.Push(lastUndoneMove);
            return lastUndoneMove;
        }
        return null;
    }
}

