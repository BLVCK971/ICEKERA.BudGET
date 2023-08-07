using BudGET.Domain.Common;

namespace BudGET.Domain.Entities;

public class Objectif : AuditableEntity
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
}
