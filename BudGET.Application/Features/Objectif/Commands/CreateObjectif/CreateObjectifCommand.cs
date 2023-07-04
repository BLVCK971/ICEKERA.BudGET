using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommand : IRequest<CreateObjectifCommandResponse>
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

