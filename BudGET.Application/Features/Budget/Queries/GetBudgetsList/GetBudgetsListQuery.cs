using MediatR;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetsList
{
    public class GetBudgetsListQuery : IRequest<List<BudgetListVm>>
    {
    }
}

