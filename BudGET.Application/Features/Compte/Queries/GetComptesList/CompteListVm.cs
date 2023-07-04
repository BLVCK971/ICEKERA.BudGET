namespace BudGET.Application.Features.Comptes.Queries.GetComptesList;
public class CompteListVm
{
    public Guid CompteId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CompanyDto? Company { get; set; }
    public ICollection<ReportVm>? Reports { get; set; }
}

