using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.UpdateObjectif
{
    public class UpdateObjectifCommand : IRequest
    {
        public Guid ObjectifId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

