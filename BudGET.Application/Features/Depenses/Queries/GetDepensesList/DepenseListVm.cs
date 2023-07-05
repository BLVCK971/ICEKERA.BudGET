namespace BudGET.Application.Features.Depenses.Queries.GetDepensesList;
public class DepenseListVm
{
    public Guid DepenseId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CompanyDto? Company { get; set; }
    public ICollection<ReportVm>? Reports { get; set; }
}

