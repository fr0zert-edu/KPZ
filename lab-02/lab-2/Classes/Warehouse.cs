using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace lab_2;

public class Warehouse : IWarehouse // Single Responsibility: this class only contains information about products in the warehouse, while WarehouseManager will be manage this class by adding or removing products and etc. 
{
    public Guid Id { get; set; }
    public IWarehouseCategory Category { get; set; }
    public int ProdCount { get; set; }
    public DateTime Date { get; set; }

    public List<Product> Products { get; }

    public Warehouse(IWarehouseCategory category)
    {
        Id = new Guid();
        Products = new List<Product>();
        ProdCount = Products.Count;
        Category = category;
    }
    
    public string GetProductList()
    {
        var strBld = new StringBuilder();
        strBld.AppendLine($"Products on warehouse {this.Id}: ");
        strBld.AppendLine($"{"Name":10} {"Unit":10} {"Price":10}");
        foreach (var product in Products)
        {
            strBld.AppendLine($"{product.Name:10} {product.Unit:10} {product.Price.ToString():10}");
        }
        return strBld.ToString();
    }
    
    
    
}