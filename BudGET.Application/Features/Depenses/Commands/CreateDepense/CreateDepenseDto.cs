using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense;

public class CreateDepenseDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public Guid BudgetId { get; set; }
    public BudgetDto Budget { get; set; } = default!;
}

