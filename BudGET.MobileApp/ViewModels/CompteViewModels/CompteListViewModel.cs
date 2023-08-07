using BudGET.MobileApp.ViewModels.BudgetViewModels;
using BudGET.MobileApp.ViewModels.DepenseViewModels;
using BudGET.MobileApp.ViewModels.ObjectifViewModels;
using BudGET.MobileApp.ViewModels.SalaireViewModels;

namespace BudGET.MobileApp.ViewModels.CompteViewModels;

public class CompteListViewModel
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
    public double Montant { get; set; }
    public bool EstCompteCourant { get; set; } = false;
}
