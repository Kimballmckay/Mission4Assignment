using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class TicTacToeTools
    {
        public string PrintBoard(char[,] board)
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
        }
    }
}
