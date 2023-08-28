using System.Runtime.CompilerServices;

namespace ConsoleApp;

public class Player
{
    public string PlayerSym { get; set; }
    public int PlayerWins { get; set; }
    public Player()
    {
        PlayerWins = 0;
    }

    public void SetSym(string sym)
    {
        bool isok=false;
        do
        {
            if (sym == "X" || sym == "O")
            {
                isok = true;
                
            }
            else
            {
                Console.WriteLine("Wrong symbol, try again!");
                sym=Console.ReadLine();

            }
        } while (!isok);
        
        PlayerSym = sym;
    }

   
}
