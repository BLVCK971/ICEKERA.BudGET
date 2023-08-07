using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Queries.GetSalaireDetail
{
    public class GetSalaireDetailQuery : IRequest<SalaireDetailVm>
    {
        public Guid Id { get; set; }
    }
}

