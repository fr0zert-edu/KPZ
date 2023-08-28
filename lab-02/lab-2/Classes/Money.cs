namespace lab_2;

public class Money
{
    private int _bill;
    private int _coin;

    public Money(int bill, int coin)
    {
        _bill = bill;
        _coin = coin;
    }

    public string GetMoney(Money money)
    {
        return $"{money._bill}.{money._coin}";
    }

    public void ChangeMoney(int bill, int coin)
    {
        this._bill = bill;
        this._coin = coin;
    }

    public override string ToString()
    {
        return $"{_bill},{_coin}";
    }
}