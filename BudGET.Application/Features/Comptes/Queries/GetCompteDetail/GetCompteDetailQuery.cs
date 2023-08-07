using MediatR;

namespace BudGET.Application.Features.Comptes.Queries.GetCompteDetail
{
    public class GetCompteDetailQuery : IRequest<CompteDetailVm>
    {
        public Guid CompteId { get; set; }
    }
}

