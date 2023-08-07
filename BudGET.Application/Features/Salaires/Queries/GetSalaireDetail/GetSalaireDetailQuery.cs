using MediatR;

namespace BudGET.Application.Features.Salaires.Queries.GetSalaireDetail
{
    public class GetSalaireDetailQuery : IRequest<SalaireDetailVm>
    {
        public Guid Id { get; set; }
    }
}

