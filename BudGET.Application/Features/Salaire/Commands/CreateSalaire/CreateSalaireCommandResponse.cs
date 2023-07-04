using BudGET.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommandResponse : BaseResponse
    {
        public CreateSalaireCommandResponse() : base()
        {

        }

        public CreateSalaireDto Salaire { get; set; }
    }
}

