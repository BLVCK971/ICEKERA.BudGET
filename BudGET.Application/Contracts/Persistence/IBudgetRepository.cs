using BudGET.Domain.Entities;

namespace BudGET.Application.Contracts.Persistence
{
    public interface IBudgetRepository : IAsyncRepository<Budget>
    {
    }
}
