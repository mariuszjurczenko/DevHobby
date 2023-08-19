using DevHobby.Models.Entities;

namespace DevHobby.Models.Repositories;

public interface IOrderRepository
{
    void CreateOrder(Order order);
}
