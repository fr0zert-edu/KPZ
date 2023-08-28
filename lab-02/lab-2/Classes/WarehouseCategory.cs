namespace lab_2;

public class WarehouseCategory:ICategory, IWarehouseCategory // Interface segregation: WarehouseCategory implements ICategory and IWarehouseCategory interfaces, so they have different props and methods for different classes of categories
{
    public Guid Id { get; set; }
    public string CompareUnit { get; set; }
    public string Name { get; set; }

    public WarehouseCategory(string name, string compareUnit)
    {
        Name = name;
        CompareUnit = compareUnit;
        Id = new Guid();
    }
}