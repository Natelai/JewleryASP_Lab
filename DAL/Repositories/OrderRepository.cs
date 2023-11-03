using DAL;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Entities;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(JewleryDBContext dbContext) : base(dbContext)
    { }
}