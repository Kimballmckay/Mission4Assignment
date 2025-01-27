using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class TicTacToeTools
    {

        // Receive game board array as input
        public CheckWinner(char[,] array)
        {
            // gameMessage defaults to draw
            string gameMessage = "It's a draw!";

            //Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] != ' ' && array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2])
                {
                    gameMessage = $"{array[i, 0]} Wins!";
                }
                if (array[0, i] != ' ' && array[0, i] == array[1, i] && array[1, i] == array[2, i])
                {
                    gameMessage = $"{array[0, i]} Wins!";
                }
            }

            //Check diagonals
            if (gameMessage == "It\'s a draw!")
            {
                if (array[0, 0] != ' ' && array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
                {
                    gameMessage = $"{array[0, 0]} Wins!";
                }
                if (array[0, 2] != ' ' && array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
                {
                    gameMessage = $"{array[0, 2]} Wins!";
                }
            }
            

            //Check if there are empty boxes
            if (gameMessage == "It\'s a draw!")
            {
                for (int i = 0; i < 3; ++i) // Iterate through rows
                {
                    for (int j = 0; j < 3; ++j) // Iterate through columns
                    {
                        if (array[i, j] == ' ')
                        {
                            // Game continues if there are still empty spaces
                            gameMessage = "The game continues...";
                        }
                    }
                }
            }
            
            // Return message
            return gameMessage;
        }
    }
}
