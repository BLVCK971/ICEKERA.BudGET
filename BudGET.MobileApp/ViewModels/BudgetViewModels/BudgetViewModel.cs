namespace BudGET.MobileApp.ViewModels.BudgetViewModels;

public class BudgetViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Montant { get; set; }
    public bool Exception { get; set; } = false;
}
