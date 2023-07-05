using BudGET.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommandResponse : BaseResponse
    {
        public CreateBudgetCommandResponse() : base()
        {

        }

        public CreateBudgetDto Budget { get; set; }
    }
}

