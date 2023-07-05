using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;

namespace BudGET.Persistence.Repositories;

public class SalaireRepository : BaseRepository<Salaire>, ISalaireRepository
{
    public SalaireRepository(BudGETDbContext dbContext) : base(dbContext)
    {
    }
}