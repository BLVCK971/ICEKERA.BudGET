using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense;

public class CreateDepenseDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public bool Prevu { get; set; } = false;

    public Guid BudgetId { get; set; }
    public BudgetDto Budget { get; set; } = default!;
    public Guid CompteId { get; set; }
    public Compte CompteCredite { get; set; } = default!;
}

