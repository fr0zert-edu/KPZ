namespace ConsoleApp;

public class RoundManager
{
    public Player? player1;
    public Player? player2;
    private Engine? engine;
    bool isRoundEnded = false;
    private bool currentPlayerFlag= true;
    UI ui = new UI();
    public void Round(Board board)
    {
        do
        {
           
            if (checkPlayerSymbol(player1) == currentPlayerFlag)
            {
                ui.PrintBoard(board, board.boardArray, player1, player2, player1);
                board.Input(board,player1);
                ChangeFlag();
                RoundWinControl(board,player1);
            }
            else
            {
                ui.PrintBoard(board, board.boardArray, player1, player2, player2);
                board.Input(board,player2);
                ChangeFlag();
                RoundWinControl(board,player2);
            }

            
        } while (!isRoundEnded);

        Console.ReadKey();
    }

    private bool checkPlayerSymbol(Player player)
    {
        if (player.PlayerSym == "X")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void ChangeFlag()
    {
        if (currentPlayerFlag)
        {
            currentPlayerFlag = false;
        }
        else
        {
            currentPlayerFlag = true;
        }
    }

    private void RoundWinControl(Board board, Player CurrentPlayerParam)
    {
        
            isRoundEnded = CombinationsCheck(CurrentPlayerParam.PlayerSym, board.boardArray);
            if (isRoundEnded)
            {
                
                ui.PrintBoard(board, board.boardArray, player1, player2, CurrentPlayerParam);
                CurrentPlayerParam.PlayerWins++;
                Console.WriteLine($"player {CurrentPlayerParam.PlayerSym} won");
                ChangeFlag();
            }
           
    }

    private bool CombinationsCheck(string symbol, string[] board)
    {
        
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == symbol && board[i + 1] == symbol && board[i + 2] == symbol)
                {
                    return true;
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == symbol && board[i + 3] == symbol && board[i + 6] == symbol)
                {
                    return true;
                }
            }

            
            if ((board[0] == symbol && board[4] == symbol && board[8] == symbol) || (board[2] == symbol && board[4] == symbol && board[6] == symbol))
            {
                return true;
            }

        
            return false;
        


    }
}