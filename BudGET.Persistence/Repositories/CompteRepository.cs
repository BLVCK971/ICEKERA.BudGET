using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;

namespace BudGET.Persistence.Repositories;

public class CompteRepository : BaseRepository<Compte>, ICompteRepository
{
    public CompteRepository(BudGETDbContext dbContext) : base(dbContext)
    {
    }
}
