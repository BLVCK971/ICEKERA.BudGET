namespace BudGET.Application.Features.Salaires.Queries.GetSalairesList;
public class SalaireListVm
{
    public Guid SalaireId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CompanyDto? Company { get; set; }
    public ICollection<ReportVm>? Reports { get; set; }
}

