using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    public class TicTacToeTools
    {

        public string PrintBoard(string[,] board)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < board.GetLength(0); i++) // Iterates through the rows
            {
                for (int j = 0; j < board.GetLength(1); j++) // Iterates through the columns
                {
                    Console.Write(board[i, j]); // Print the value at that location
                    if (j < board.GetLength(1) - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine(); // Move to the next line

                if (i < board.GetLength(0) - 1)
                {
                    Console.WriteLine("---------"); // Prints row dividing lines
                }
            }

            return sb.ToString();
        }

        // Receive game board array as input
        public bool CheckWinner(string[,] array, out string gameMessage)
        {
            // Default message is a draw
            gameMessage = "It's a draw!";

            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2] && (array[i, 0] == "X" || array[i, 0] == "O"))
                {
                    gameMessage = $"{array[i, 0]} Wins!";
                    return false; // Game ends with a win
                }

                // Check columns
                if (array[0, i] == array[1, i] && array[1, i] == array[2, i] && (array[0, i] == "X" || array[0, i] == "O"))
                {
                    gameMessage = $"{array[0, i]} Wins!";
                    return false; // Game ends with a win
                }
            }

            // Check diagonals
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && (array[0, 0] == "X" || array[0, 0] == "O"))
            {
                gameMessage = $"{array[0, 0]} Wins!";
                return false; // Game ends with a win
            }

            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && (array[0, 2] == "X" || array[0, 2] == "O"))
            {
                gameMessage = $"{array[0, 2]} Wins!";
                return false; // Game ends with a win
            }

            // Check if there are any empty spots left
            for (int i = 0; i < 3; ++i) // Iterate through rows
            {
                for (int j = 0; j < 3; ++j) // Iterate through columns
                {
                    if (array[i, j] != "X" && array[i, j] != "O") // Check for empty spot
                    {
                        gameMessage = "The game continues...";
                        return true; // Game continues
                    }
                }
            }

            // If there are no empty spots and no winner, it's a draw
            return false; // No empty spots, game ends in a draw
        }

    }
}
