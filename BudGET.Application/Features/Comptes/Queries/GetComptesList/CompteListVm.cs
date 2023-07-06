namespace BudGET.Application.Features.Comptes.Queries.GetComptesList;
public class CompteListVm
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool EstCompteCourant { get; set; } = false;
    public ICollection<BudgetDto>? Budgets { get; set; }
    public ICollection<DepenseDto>? Depenses { get; set; }
    public ICollection<ObjectifDto>? Objectifs { get; set; }
    public ICollection<SalaireDto>? Salaires { get; set; }
}

