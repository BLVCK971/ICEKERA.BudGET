using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetDetail
{
    public class GetBudgetDetailQuery : IRequest<BudgetDetailVm>
    {
        public Guid Id { get; set; }
    }
}

