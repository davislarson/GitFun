using System.Security.Principal;
using GitFun;

Console.WriteLine("Welcome to the Program!");

char[] board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];
int choice = 0;
GameTools gt = new GameTools();
bool gameWon = false;
bool oTurn = false;
char winner = new char();



while (!gameWon)
{
    // Print out the gameboard
    gt.PrintBoard(board);
    
    // Get X's move and check for a winner
    Console.WriteLine(($"It is {(oTurn ? "O" : "X")}'s turn. Where would you like to go?"));
    choice = Convert.ToInt32(Console.ReadLine());
    board[choice - 1] = 'X';
    gameWon = gt.CheckWinner(board, 'X');
    if (gameWon)
    {
        winner = 'X';
        break;
    }
    oTurn = true;
    
    gt.PrintBoard(board);
    
    // Get O's move and check for a winner
    Console.WriteLine(($"It is {(oTurn ? "O" : "X")}'s turn. Where would you like to go?"));
    choice = Convert.ToInt32(Console.ReadLine());
    board[choice - 1] = 'O';
    gameWon = gt.CheckWinner(board, 'O');
    if (gameWon)
    {
        winner = 'O';
        break;
    }
    oTurn = false;
}
Console.WriteLine("Final Board\n ------------------");
gt.PrintBoard(board);
Console.WriteLine($"Congratulations {winner}! You won the game!");

