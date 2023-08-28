using Console = System.Console;

namespace ConsoleApp;

public class Engine
{
    public Player Player1 = new Player();
    public Player Player2 = new Player();
    private Board? _board;
    private RoundManager rm = new RoundManager();
    private bool MatchWinFlag = false;

    public void Initialize()
    {
        string tmpSym;
        Console.WriteLine("Let`s play Tic Tac Toe");
        Console.Write("Player 1:");
        tmpSym = Console.ReadLine()!;
        Player1.SetSym(tmpSym);

        bool isok = false;
        do
        {
            Console.Write("Player 2:");
            tmpSym = Console.ReadLine()!;
            if (tmpSym != Player1.PlayerSym)
                isok = true;
            else
            {
                Console.WriteLine("Symbol already chosen!");
            }
        } while (!isok);
        
        Player2.SetSym(tmpSym);
        _board = new Board();
        rm.player1 = Player1;
        rm.player2 = Player2;
        rm.Round(_board);
       
        ContinueGame();
    }
    

    private void ContinueGame()
    {
        Console.Write("Continue game?(y/n) ");
        string continueGame = Console.ReadLine()!.ToLower();
        if (continueGame == "y") {
            changeSymbol(Player1, Player2);
            _board = new Board();
            rm.Round(_board);
            MatchWinFlag = CheckMatchWin(Player1, Player2);
            if (MatchWinFlag)
            {

                Console.Clear();
                Console.WriteLine(WinTextMessage(Player1, Player2));
                Console.WriteLine($"Score: {Player1.PlayerWins}:{Player2.PlayerWins}");
                Console.ReadKey();
            }
            else
            {
                ContinueGame();
            }

        }
    }

    private void changeSymbol(Player player1, Player player2)
    {
        string tmp = player1.PlayerSym;
        player1.PlayerSym = player2.PlayerSym;
        player2.PlayerSym = tmp;
    }
    private bool CheckMatchWin(Player player1, Player player2)
    {
        if (player1.PlayerWins == 2 || player2.PlayerWins == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private string WinTextMessage(Player player1, Player player2)
    {
        if (player1.PlayerWins != player2.PlayerWins&&player1.PlayerWins!=1)
        {
            if (player1.PlayerWins == 2)
            {
                return $"Player 1 wins!";
            }
            else if (player2.PlayerWins == 2)
            {
                return $"Player 2 wins!";
            }
        }
        else
        {
            return "Draw!";
        }
        return null;
    }
    
}

    