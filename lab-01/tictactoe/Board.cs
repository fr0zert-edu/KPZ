namespace ConsoleApp;

public class Board
{
    public string[] boardArray ={ "A", "B", "C", "D", "E", "F", "G", "H", "I" };
    
    private void ChangeBoard(int index, Player currentPlayer)
    {
        boardArray[index] = currentPlayer.PlayerSym;
    }

    private bool uniqBoardCheck(int index, Board board)
    {
        if (board.boardArray[index] == "X" || board.boardArray[index] == "O")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void Input(Board board, Player currentPlayer)
    {
        bool isok = false;
        int intIndex = 0;
        do
        {
            string selectedCellStr = Console.ReadLine()!.ToUpper();
            char charIndex;

            if (!char.TryParse(selectedCellStr, out charIndex))
            {
                Console.WriteLine("Entered invalid cell number!");
            }
            else if (charIndex < 'A' || charIndex > 'I')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ther`s no cell \"{charIndex}\" on the field.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else {
                CellLetter cell = (CellLetter)Enum.Parse(typeof(CellLetter), charIndex.ToString());
                intIndex = (int)cell;
                if (!board.uniqBoardCheck(intIndex - 1, board))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"This cell is already taken!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    isok = true;
                }
            }
            
        } while (!isok);
        
        board.ChangeBoard(intIndex - 1,currentPlayer);
    }
}