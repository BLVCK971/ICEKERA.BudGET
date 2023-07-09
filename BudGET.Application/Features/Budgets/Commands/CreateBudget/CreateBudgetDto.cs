namespace BudGET.Application.Features.Budgets.Commands.CreateBudget;

public class CreateBudgetDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool Exception { get; set; } = false;
}

