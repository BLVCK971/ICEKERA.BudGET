namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire;

public class CreateSalaireDto
{
    public Guid SalaireId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
}

