using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;

namespace BudGET.Persistence.Repositories;

public class ObjectifRepository : BaseRepository<Objectif>, IObjectifRepository
{
    public ObjectifRepository(BudGETDbContext dbContext) : base(dbContext)
    {
    }
}