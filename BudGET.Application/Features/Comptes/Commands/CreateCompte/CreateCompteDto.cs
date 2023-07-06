namespace BudGET.Application.Features.Comptes.Commands.CreateCompte;

public class CreateCompteDto
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool EstCompteCourant { get; set; } = false;
}

