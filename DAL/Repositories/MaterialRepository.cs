using DAL;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Entities;

public class MaterialRepository : GenericRepository<Material>, IMaterialRepository
{
    public MaterialRepository(JewleryDBContext dbContext) : base(dbContext)
    {
    }
}