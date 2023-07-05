using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;

namespace BudGET.Persistence.Repositories;

public class BudgetRepository : BaseRepository<Budget>, IBudgetRepository
{
    public BudgetRepository(BudGETDbContext dbContext) : base(dbContext)
    {
    }
}
