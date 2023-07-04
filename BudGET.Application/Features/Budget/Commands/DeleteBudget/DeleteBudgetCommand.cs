using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Commands.DeleteBudget
{
    public class DeleteBudgetCommand : IRequest
    {
        public Guid BudgetId { get; set; }
    }
}

