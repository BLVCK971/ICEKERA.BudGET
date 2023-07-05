using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.UpdateDepense
{
    public class UpdateDepenseCommand : IRequest
    {
        public Guid DepenseId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

