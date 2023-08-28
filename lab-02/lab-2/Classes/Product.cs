namespace lab_2;

public class Product
{
    public string Name { get; set; }

    private IProductCategory Category { get; set; }
    public string Unit { get; private set; }
    public Money Price { get; set; }
    public Product(string name, Money price, ProductCategory category)
    {
        Name = name;
        Unit = category.Unit;
        Price = price;
    }
    public void LowerPrice(string amount)
    {
        int bill = int.Parse(amount.Split('.')[0]);
        int coin = int.Parse(amount.Split('.')[1]);
        int tmpbill = int.Parse(amount.Split('.')[0]);
        int tmpcoin = int.Parse(amount.Split('.')[1]);
        bill = tmpbill - bill;
        coin = tmpcoin - coin;
        Price.ChangeMoney(bill, coin);
    }
    public void UpperPrice(string amount)
    {
        int bill = int.Parse(amount.Split('.')[0]);
        int coin = int.Parse(amount.Split('.')[1]);
        int tmpbill = int.Parse(amount.Split('.')[0]);
        int tmpcoin = int.Parse(amount.Split('.')[1]);
        bill = tmpbill + bill;
        coin = tmpcoin + coin;
        Price.ChangeMoney(bill,coin);
    }
    
}