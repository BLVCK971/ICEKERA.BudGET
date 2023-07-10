using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.DeleteCompte
{
    public class DeleteCompteCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

