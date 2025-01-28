namespace GitFun;

public class GameTools
{
    public void PrintBoard(char[] board)
    {
        Console.Write(
            $" {board[0]} | {board[1]} | {board[2]} \n" +
            $"---+---+---\n" +
            $" {board[3]} | {board[4]} | {board[5]} \n" +
            $"---+---+---\n" +
            $" {board[6]} | {board[7]} | {board[8]} \n");
        
    }

    public bool CheckWinner(char[] board, char player)
    {
        bool winner = false;
        List<int[]> winSituations =
        [
            // Horizontal
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9],
            // Vertical
            [1, 4, 7],
            [2, 5, 8],
            [3, 6, 9],
            // Diagonal
            [1, 5, 9],
            [3, 5, 7]
        ];

        for (int i = 0; i < winSituations.Count; i++)
        {
            if (board[(winSituations[i][0]) - 1] == player && (board[(winSituations[i][1]) - 1] == player && (board[(winSituations[i][2]) - 1] == player)))
            {
                winner = true;
            }
        }
        
        return winner;
    }
}