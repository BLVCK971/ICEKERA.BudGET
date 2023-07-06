using BudGET.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.CreateCompte
{
    public class CreateCompteCommandResponse : BaseResponse
    {
        public CreateCompteCommandResponse() : base()
        {

        }

        public CreateCompteDto Compte { get; set; } = default!;
    }
}

