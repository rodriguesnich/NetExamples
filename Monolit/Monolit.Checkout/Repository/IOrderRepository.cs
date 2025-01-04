using Monolit.Checkout.Domain.Entities;

namespace Monolit.Checkout.Repository;

public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(Guid id);
    Task<IEnumerable<Order>> GetByCustomerEmailAsync(string email);
    Task<Order> CreateAsync(Order order);
    Task UpdateAsync(Order order);
}
