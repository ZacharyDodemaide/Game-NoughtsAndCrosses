using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    public class GameManager
    {
    public void play(WildState wildState)
    {
        string input;
        do
        {
            Console.WriteLine("Enter (row, column, token) or Q to quit:");
            input = Console.ReadLine();
            Console.WriteLine();

            string token;
            string[] values = input.Split(',');
            int.TryParse(values[0], out int row);
            int.TryParse(values[1], out int col);
            token = values[2];

            if (token == "X" || token == "O")
            {
                wildState.Board.UpdateBoard(row, col, token);
                wildState.Board.ShowBoard();

            }
            else if (input != "Q")
            {
                Console.WriteLine("Invalid input. Please enter X, O, or Q.");
            }
        } while (input != "Q");
    }
    
    }

