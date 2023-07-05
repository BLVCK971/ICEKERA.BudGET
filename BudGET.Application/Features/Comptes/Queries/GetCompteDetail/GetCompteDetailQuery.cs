using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Queries.GetCompteDetail
{
    public class GetCompteDetailQuery : IRequest<CompteDetailVm>
    {
        public Guid CompteId { get; set; }
    }
}

