using MediatR;

namespace BudGET.Application.Features.Salaires.Queries.GetSalairesList
{
    public class GetSalairesListQuery : IRequest<List<SalaireListVm>>
    {
    }
}

