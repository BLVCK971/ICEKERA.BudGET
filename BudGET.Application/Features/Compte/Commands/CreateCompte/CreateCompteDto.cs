namespace BudGET.Application.Features.Comptes.Commands.CreateCompte;

public class CreateCompteDto
{
    public Guid CompteId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
}

