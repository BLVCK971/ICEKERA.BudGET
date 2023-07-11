using BudGET.MobileApp.ViewModels.BudgetViewModels;
using BudGET.MobileApp.ViewModels.DepenseViewModels;
using BudGET.MobileApp.ViewModels.ObjectifViewModels;
using BudGET.MobileApp.ViewModels.SalaireViewModels;

namespace BudGET.MobileApp.ViewModels.CompteViewModels;

public class CompteViewModel
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool EstCompteCourant { get; set; } = false;
    public ICollection<DepenseViewModel> Depenses { get; set; }
    public ICollection<BudgetViewModel> Budgets { get; set; }
    public ICollection<ObjectifViewModel> Objectifs { get; set; }
    public ICollection<SalaireViewModel> Salaires { get; set; }
}
