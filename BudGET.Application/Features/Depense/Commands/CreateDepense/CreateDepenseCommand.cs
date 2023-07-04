using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense
{
    public class CreateDepenseCommand : IRequest<CreateDepenseCommandResponse>
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

