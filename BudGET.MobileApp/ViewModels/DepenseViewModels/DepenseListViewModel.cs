using BudGET.MobileApp.ViewModels.BudgetViewModels;
using BudGET.MobileApp.ViewModels.CompteViewModels;

namespace BudGET.MobileApp.ViewModels.DepenseViewModels;

public class DepenseListViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public bool Prevu { get; set; } = false;

    public BudgetViewModel Budget { get; set; } = default!;
    public CompteViewModel CompteCredite { get; set; } = default!;
}
