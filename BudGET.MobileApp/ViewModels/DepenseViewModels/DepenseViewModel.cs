using BudGET.MobileApp.ViewModels.BudgetViewModels;

namespace BudGET.MobileApp.ViewModels.DepenseViewModels;

public class DepenseViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public Guid BudgetId { get; set; }
    public BudgetViewModel Budget { get; set; } = default!;
}
