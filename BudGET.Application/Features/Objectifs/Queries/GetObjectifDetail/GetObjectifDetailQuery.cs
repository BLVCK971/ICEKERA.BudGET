using MediatR;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail
{
    public class GetObjectifDetailQuery : IRequest<ObjectifDetailVm>
    {
        public Guid ObjectifId { get; set; }
    }
}

