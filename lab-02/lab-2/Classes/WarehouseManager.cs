namespace lab_2;

public class WarehouseManager : IWarehouseManager// Open-Closed: by using this class we can add new operations for Warehouse class without changing it
{//Dependency inversion: this class depends on warehouse but warehouse doesn`t depend on this class;
    public IWarehouse Warehouse { get; set; } // Liskov substitution: this prop can contain different types of warehouses which implements IWarehouse interface so we haven`t to know which type of warehouse we will be sent to this class and it will be work!)))  
    public WarehouseManager(Warehouse warehouse)
    {
        Warehouse = warehouse;
    }
    
    public Product AddProduct(Product product)
    {
        if (Warehouse.Category.CompareUnit == product.Unit)
        {
            Warehouse.Products.Add(product);
            Warehouse.Date = DateTime.Now;
            Warehouse.ProdCount = Warehouse.Products.Count;
            Console.WriteLine(Reporting.IncomeReport(product, this.Warehouse));
        }
        else
        {
            Console.WriteLine("This product is not compare to this warehouse!");
        }

        
        return product;
    }

    public Product RemoveProduct(Product product)
    {
        Warehouse.Products.Remove(product);
        Warehouse.Date = DateTime.Now;
        Warehouse.ProdCount = Warehouse.Products.Count;
        Console.WriteLine(Reporting.OutcomeReport(product, this.Warehouse));
        return product;
    }
}