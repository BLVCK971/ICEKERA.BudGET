namespace BudGET.Application.Features.Depenses.Commands.CreateDepense;

public class BudgetDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool Exception { get; set; } = false;
}
