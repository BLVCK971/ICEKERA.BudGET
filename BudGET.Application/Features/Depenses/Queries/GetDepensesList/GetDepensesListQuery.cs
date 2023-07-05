using MediatR;

namespace BudGET.Application.Features.Depenses.Queries.GetDepensesList
{
    public class GetDepensesListQuery : IRequest<List<DepenseListVm>>
    {
    }
}

