using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Commands.DeleteSalaire
{
    public class DeleteSalaireCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

