using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense;

public class CreateDepenseDto
{
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public bool Prevu { get; set; } = false;

    public Guid BudgetId { get; set; }
    public Guid CompteId { get; set; }
}

