using BudGET.MobileApp.ViewModels.CompteViewModels;

namespace BudGET.MobileApp.ViewModels.SalaireViewModels;

public class SalaireViewModel
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
    public CompteViewModel CompteDebite { get; set; } = default!;
}
