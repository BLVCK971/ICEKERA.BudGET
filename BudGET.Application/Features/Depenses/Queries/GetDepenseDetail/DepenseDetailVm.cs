namespace BudGET.Application.Features.Depenses.Queries.GetDepenseDetail;

public class DepenseDetailVm
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }

    public Guid BudgetId { get; set; }
    public Guid CompteId { get; set; }
}