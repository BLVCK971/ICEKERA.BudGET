using MediatR;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommand : IRequest<CreateBudgetCommandResponse>
    {
        public string Nom { get; set; } = string.Empty;
        public double Montant { get; set; } = double.MinValue;
        public bool Exception { get; set; } = false;
    }
}

