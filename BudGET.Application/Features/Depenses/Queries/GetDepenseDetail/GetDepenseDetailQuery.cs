using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Queries.GetDepenseDetail
{
    public class GetDepenseDetailQuery : IRequest<DepenseDetailVm>
    {
        public Guid DepenseId { get; set; }
    }
}

