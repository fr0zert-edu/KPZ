namespace lab_2;

public interface IWarehouseManager
{
    public IWarehouse Warehouse { get; set; }
    public Product AddProduct(Product product);
    public Product RemoveProduct(Product product);
}