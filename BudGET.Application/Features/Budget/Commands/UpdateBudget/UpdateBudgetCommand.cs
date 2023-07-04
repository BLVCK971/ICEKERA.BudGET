using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommand : IRequest
    {
        public Guid BudgetId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
    }
}

