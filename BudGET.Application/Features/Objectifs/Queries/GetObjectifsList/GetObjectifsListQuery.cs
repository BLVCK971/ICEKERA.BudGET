using MediatR;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifsList
{
    public class GetObjectifsListQuery : IRequest<List<ObjectifListVm>>
    {
    }
}

