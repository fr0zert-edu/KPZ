namespace lab_2;

public interface IReporting
{
    public static abstract string IncomeReport(Product product, IWarehouse warehouse);

    public static abstract string OutcomeReport(Product product, IWarehouse warehouse);

    public static abstract string InventoryReport(IWarehouse warehouse);
}