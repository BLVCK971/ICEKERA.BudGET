using BudGET.Application.Responses;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommandResponse : BaseResponse
    {
        public CreateBudgetCommandResponse() : base()
        {

        }

        public CreateBudgetDto Budget { get; set; } = default!;
    }
}

