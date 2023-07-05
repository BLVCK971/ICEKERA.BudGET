using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Commands.UpdateSalaire
{
    public class UpdateSalaireCommand : IRequest
    {
        public Guid SalaireId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

