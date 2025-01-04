using Monolit.GeneralDomain;

namespace Monolit.Checkout.Domain.Entities;

public enum OrderStatus
{
    Pending,
    Approved
}

public class Order : BaseEntity
{
    public OrderStatus Status { get; set; }
    public decimal TotalAmount { get; set; }
    public Guid CustomerId { get; set; }
    public Client? Client { get; set; }
    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
