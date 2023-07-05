namespace BudGET.Application.Features.Comptes.Queries.GetComptesList;
public class CompteListVm
{
    public Guid CompteId { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public BudgetDto? Company { get; set; }
    public ICollection<BudgetDto>? Budgets { get; set; }
    public ICollection<DepenseDto>? Depenses { get; set; }
    public ICollection<ObjectifDto>? Objectifs { get; set; }
    public ICollection<SalaireDto>? Salaires { get; set; }
}

