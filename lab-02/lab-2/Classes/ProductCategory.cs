namespace lab_2;

public class ProductCategory : ICategory, IProductCategory// Interface segregation: ProductCategory implements ICategory and IProductCategory interfaces, so they have different props and methods for different classes of categories
{
     public Guid Id { get; set; }
     public string Unit { get; set; }
     public string Name { get; set; }

     public ProductCategory(string name, string unit)
     {
          Id = new Guid();
          Unit = unit;
          Name = name;
     }
}