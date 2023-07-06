using BudGET.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense
{
    public class CreateDepenseCommandResponse : BaseResponse
    {
        public CreateDepenseCommandResponse() : base()
        {

        }

        public CreateDepenseDto Depense { get; set; } = default!;
    }
}

