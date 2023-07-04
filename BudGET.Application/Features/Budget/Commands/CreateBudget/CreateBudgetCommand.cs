using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommand : IRequest<CreateBudgetCommandResponse>
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

