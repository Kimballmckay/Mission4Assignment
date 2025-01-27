//Welcome the user to the game
   // • Create a game board array to store the players’ choices
   // • Ask each player in turn for their choice and update the game board array
   // • Print the board by calling the method in the supporting class
   // • Check for a winner by calling the method in the supporting class, and notify the players
   //when a win has occurred and which player won the game



//welcome players to the game

using Mission4Assignment;

//create a new game
TicTacToeTools game = new TicTacToeTools();


//gameboard array 3x3
string[,] gameBoard = {
   { "1", "2", "3" },
   { "4", "5", "6" },
   { "7", "8", "9" }
};

//player1 input
int player1Input = 0;
//player2 input
int player2Input = 0;


Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("Player1: X");
Console.WriteLine("Player2: O");

TicTacToeTools.PrintBoard(gameBoard);


do
{
   Console.WriteLine("Player 1 turn: Pick a number between 1-9 to place your X");
   player1Input = int.Parse(Console.ReadLine() ?? "0");

   if (player1Input > 0 && player1Input < 10)
   {
      // Calculate row and column from input
      int row = (player1Input - 1) / 3;
      int col = (player1Input - 1) % 3;

      // Check if the spot is available
      if (gameBoard[row, col] != "X" && gameBoard[row, col] != "O")
      {
         gameBoard[row, col] = "X";
         TicTacToeTools.PrintBoard(gameBoard);
      }
      else
      {
         Console.WriteLine("Spot already taken! Try again.");
         Console.ReadKey(); // Pause to let the player read the message
         TicTacToeTools.PrintBoard(gameBoard);
      }
   }
   else
   {
      Console.WriteLine("Invalid input! Please pick a number between 1-9.");
      Console.ReadKey();
      TicTacToeTools.PrintBoard(gameBoard);
   }
   
   //player 2 turn
   Console.WriteLine("Player 2 turn: Pick a number between 1-9 to place your O");
   player2Input = int.Parse(Console.ReadLine() ?? "0");

   if (player2Input > 0 && player2Input < 10)
   {
      // Calculate row and column from input
      int row = (player2Input - 1) / 3;
      int col = (player2Input - 1) % 3;

      // Check if the spot is available
      if (gameBoard[row, col] != "X" && gameBoard[row, col] != "O")
      {
         gameBoard[row, col] = "O";
         TicTacToeTools.PrintBoard(gameBoard);
      }
      else
      {
         Console.WriteLine("Spot already taken! Try again.");
         Console.ReadKey(); // Pause to let the player read the message
         TicTacToeTools.PrintBoard(gameBoard);
      }
   }
   else
   {
      Console.WriteLine("Invalid input! Please pick a number between 1-9.");
      Console.ReadKey();
      TicTacToeTools.PrintBoard(gameBoard);
   }
} while (TicTacToeTools.CheckWinner(gameBoard));
//players choose X or O


