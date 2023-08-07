namespace BudGET.Application.Features.Salaires.Queries.GetSalairesList;
public class SalaireListVm
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
}
