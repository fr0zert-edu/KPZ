
using lab_2;

var product1 = new Product("Milk", new Money(40, 50), new ProductCategory("Dairy", "Liter"));
var product2 = new Product("Onion", new Money(3, 90), new ProductCategory("Grocery", "Kg"));
var product3 = new Product("Kefir", new Money(50, 20), new ProductCategory("Dairy", "Liter"));
var warehouse = new Warehouse(new WarehouseCategory("Dairy", "Liter"));
var warehouseManager = new WarehouseManager(warehouse);
warehouseManager.AddProduct(product1);
warehouseManager.AddProduct(product2);
warehouseManager.AddProduct(product3);
warehouseManager.RemoveProduct(product3);

Console.WriteLine(Reporting.InventoryReport(warehouse));

Console.ReadKey();