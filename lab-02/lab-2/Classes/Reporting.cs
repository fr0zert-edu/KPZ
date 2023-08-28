using System.Text;

namespace lab_2;

public class Reporting : IReporting
{
    public static string IncomeReport(Product product, IWarehouse warehouse)
    {
        var strBld = new StringBuilder();
        strBld.AppendLine($"Income product on warehouse {warehouse.Id}:");
        strBld.AppendLine($"{"Name":10} {"Unit":10} {"Price":10} {"Date":10}");
        strBld.AppendLine($"{product.Name:10} {product.Unit:10} {product.Price.ToString():10} {warehouse.Date:10}");
        return strBld.ToString();
    }
    public static string OutcomeReport(Product product, IWarehouse warehouse)
    {
        var strBld = new StringBuilder();
        strBld.AppendLine($"Outcome product on warehouse {warehouse.Id}:");
        strBld.AppendLine($"{"Name":10} {"Unit":10} {"Price":10} {"Date":10}");
        strBld.AppendLine($"{product.Name:10} {product.Unit:10} {product.Price.ToString():10} {warehouse.Date:10}");
        return strBld.ToString();
    }

    public static string InventoryReport(IWarehouse warehouse) => warehouse.GetProductList();
}