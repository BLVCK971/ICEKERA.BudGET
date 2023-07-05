using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.DeleteDepense
{
    public class DeleteDepenseCommand : IRequest
    {
        public Guid DepenseId { get; set; }
    }
}

