namespace BudGET.Application.Features.Depenses.Queries.GetDepensesList;
public class DepenseListVm
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public Guid BudgetId { get; set; }
    public BudgetDto Budget { get; set; } = default!;
    public Guid CompteId { get; set; }
    public CompteDto CompteCredite { get; set; } = default!;
}

