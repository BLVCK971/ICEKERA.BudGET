namespace BudGET.Application.Features.Budgets.Queries.GetBudgetsList;
public class BudgetListVm
{
    public Guid BudgetId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CompanyDto? Company { get; set; }
    public ICollection<ReportVm>? Reports { get; set; }
}

