using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.UpdateCompte
{
    public class UpdateCompteCommand : IRequest
    {
        public Guid CompteId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

