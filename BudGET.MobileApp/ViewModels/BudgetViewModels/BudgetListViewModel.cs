namespace BudGET.MobileApp.ViewModels.BudgetViewModels;

public class BudgetListViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool Exception { get; set; } = false;
}
