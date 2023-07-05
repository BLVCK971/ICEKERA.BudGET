namespace BudGET.Application.Features.Budgets.Commands.CreateBudget;

public class CreateBudgetDto
{
    public Guid BudgetId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
}

