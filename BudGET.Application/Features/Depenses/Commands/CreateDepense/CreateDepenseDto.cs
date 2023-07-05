namespace BudGET.Application.Features.Depenses.Commands.CreateDepense;

public class CreateDepenseDto
{
    public Guid DepenseId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
}

