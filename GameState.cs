using System;


    public interface IGameState
    {
        IBoard Board { get; set; }
        int NextPlayer { get; set; }
    }

    public class WildState : IGameState
    {
        public IBoard Board { get; set; }
        public int NextPlayer { get; set; }

        public WildState(WildBoard wb)
        {
            Board = wb;
            NextPlayer = 1; // Let's say 1 represents the first player
        }
    }
