using MediatR;

namespace BudGET.Application.Features.Depenses.Queries.GetDepenseDetail
{
    public class GetDepenseDetailQuery : IRequest<DepenseDetailVm>
    {
        public Guid DepenseId { get; set; }
    }
}

