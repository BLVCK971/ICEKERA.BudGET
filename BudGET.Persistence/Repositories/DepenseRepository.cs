using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;

namespace BudGET.Persistence.Repositories;

public class DepenseRepository : BaseRepository<Depense>, IDepenseRepository
{
    public DepenseRepository(BudGETDbContext dbContext) : base(dbContext)
    {
    }
}
