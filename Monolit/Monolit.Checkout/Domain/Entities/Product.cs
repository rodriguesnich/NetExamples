namespace Monolit.Checkout.Domain.Entities;

public class Product
{
    public string Name {get; set;} = string.Empty;

    public string Description {get; set;} = string.Empty;
    public double Price {get; set;}
}
