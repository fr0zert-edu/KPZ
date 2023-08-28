namespace lab_2;

public interface IWarehouse
{
    public Guid Id { get; set; }
    public int ProdCount { get; set; }
    
    public IWarehouseCategory Category { get; set; }

    public DateTime Date { get; set; }

    public List<Product> Products { get; }

    public string GetProductList();
}