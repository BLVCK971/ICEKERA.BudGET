using BudGET.MobileApp.ViewModels.BudgetViewModels;
using BudGET.MobileApp.ViewModels.CompteViewModels;

namespace BudGET.MobileApp.ViewModels.DepenseViewModels;

public class DepenseListViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; }
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public bool Prevu { get; set; }
    public Guid BudgetId { get; set; }
    public BudgetListViewModel Budget { get; set; }
    public Guid CompteId { get; set; }
    public CompteListViewModel CompteCredite { get; set; }
}
