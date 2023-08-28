namespace ConsoleApp;

public class UI
{
    
    public void PrintBoard(Board board, string[] cell,Player player1,Player player2, Player currentPlayer)
    {

        Console.Clear();
        Console.WriteLine("Let`s play Tic Tac Toe\n\n");
        Console.WriteLine($"Player 1: {player1.PlayerSym}");
        Console.WriteLine($"Player 2: {player2.PlayerSym}\n\n");
        Console.WriteLine($"Score: {player1.PlayerWins}:{player2.PlayerWins}");
        Console.WriteLine($"Player {currentPlayer.PlayerSym}`s turn. Select from 1 to 9 from the game board.\n\n");
        Console.WriteLine($" {cell[0]} | {cell[1]} | {cell[2]} \n---+---+---\n" +
                          $" {cell[3]} | {cell[4]} | {cell[5]} \n---+---+---\n" +
                          $" {cell[6]} | {cell[7]} | {cell[8]} \n\n");
       
       
    }

   
}