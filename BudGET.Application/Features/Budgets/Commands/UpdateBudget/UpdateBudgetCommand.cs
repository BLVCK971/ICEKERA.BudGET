using MediatR;

namespace BudGET.Application.Features.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Montant { get; set; } = double.MinValue;
        public bool Exception { get; set; } = false;
    }
}

