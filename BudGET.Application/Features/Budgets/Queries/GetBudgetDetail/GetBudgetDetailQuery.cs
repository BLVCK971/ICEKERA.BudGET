using MediatR;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetDetail
{
    public class GetBudgetDetailQuery : IRequest<BudgetDetailVm>
    {
        public Guid Id { get; set; }
    }
}

