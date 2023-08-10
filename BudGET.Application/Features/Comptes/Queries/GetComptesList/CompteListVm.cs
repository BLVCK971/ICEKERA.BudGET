namespace BudGET.Application.Features.Comptes.Queries.GetComptesList;
public class CompteListVm
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool EstCompteCourant { get; set; } = false;
}

