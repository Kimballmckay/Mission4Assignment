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
        public CheckWinner(char[,] array, out bool gameContinue)
        {
            // gameMessage defaults to draw
            string gameMessage = "It's a draw!";
            bool gameContinue = false;

            //Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2] && !char.IsDigit(array[i, 0]))
                {
                    gameMessage = $"{array[i, 0]} Wins!";
                    break;
                }
                if (array[0, i] == array[1, i] && array[1, i] == array[2, i] && !char.IsDigit(array[0, i]))
                {
                    gameMessage = $"{array[0, i]} Wins!";                 
                    break;
                }
            }

            //Check diagonals
            if (gameMessage == "It\'s a draw!")
            {
                if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && !char.IsDigit(array[0, 0]))
                {
                    gameMessage = $"{array[0, 0]} Wins!";
                }

                if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && !char.IsDigit(array[0, 2]))
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
                        if (char.IsDigit(array[i, j]))
                        {
                            // Game continues if there are still empty spaces
                            gameMessage = "The game continues...";
                            gameContinue = true;
                            break;
                        }
                    }
                    if (gameMessage == "The game continues...")
                    {
                        break;
                    }
                }
            }
            
            // Return message
            return gameMessage;
        }
    }
}
