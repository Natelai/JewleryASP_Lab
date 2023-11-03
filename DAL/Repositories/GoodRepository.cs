using DAL;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Entities;

public class GoodRepository : GenericRepository<Good>, IGoodRepository
{
    public GoodRepository(JewleryDBContext dbContext) : base(dbContext)
    {
    }
}