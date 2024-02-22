using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class program
    {
        static void Main(string[] args)
        {
            // Instantiate a new WildBoard
            WildBoard wildBoard = new WildBoard();

            WildState wildState = new WildState(wildBoard);

            GameManager gameManager = new GameManager();
            gameManager.play(wildState);

        // Display the initial state of the WildBoard
        wildBoard.ShowBoard();

            Console.ReadKey();
        }
    }


    public interface IBoard
    {
        void Setup();
        void UpdateBoard(int row, int col, string playerSymbol);
        void ShowBoard();
    }

    public class WildBoard : IBoard
    {
        private string[,] board;

        public WildBoard()
        {
            board = new string[3, 3];
            Setup();
        }

        public void Setup()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = "   ";
                }
            }
        }

        public void UpdateBoard(int row, int col, string token)
        {
            board[row, col] = token;
        }

        public void ShowBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if (col < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (row < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }
    }




