using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Compte.Queries.GetComptesList
{
    public class DepenseDto
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double Valeur { get; set; }
        public Guid BudgetId { get; set; }
        public Budget Budget { get; set; } = default!;
    }
}
