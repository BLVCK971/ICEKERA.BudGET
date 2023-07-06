using BudGET.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommandResponse : BaseResponse
    {
        public CreateObjectifCommandResponse() : base()
        {

        }

        public CreateObjectifDto Objectif { get; set; } = default!;
    }
}

