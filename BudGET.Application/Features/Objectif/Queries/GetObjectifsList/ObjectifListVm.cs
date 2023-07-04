namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifsList;
public class ObjectifListVm
{
    public Guid ObjectifId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CompanyDto? Company { get; set; }
    public ICollection<ReportVm>? Reports { get; set; }
}

