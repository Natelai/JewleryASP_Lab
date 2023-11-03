using DAL;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Entities;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(JewleryDBContext dbContext) : base(dbContext)
    {
    }
}