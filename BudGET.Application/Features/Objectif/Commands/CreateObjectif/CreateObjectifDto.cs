namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif;

public class CreateObjectifDto
{
    public Guid ObjectifId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
}

