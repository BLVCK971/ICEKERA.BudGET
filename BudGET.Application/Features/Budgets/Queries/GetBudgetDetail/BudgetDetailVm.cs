namespace BudGET.Application.Features.Budgets.Queries.GetBudgetDetail
{
    public class BudgetDetailVm
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Montant { get; set; }
        public bool Exception { get; set; }
    }
}

