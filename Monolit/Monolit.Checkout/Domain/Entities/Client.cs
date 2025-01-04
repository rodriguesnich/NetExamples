using Monolit.GeneralDomain;

namespace Monolit.Checkout.Domain.Entities;

public class Client : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public int Number { get; set; } 
    public string Complement { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public Guid? OrderId { get; set; }
    public Order? Order { get; set; }
}
