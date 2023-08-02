namespace BudGET.Application.Features.Salaires.Queries.GetSalairesList;
public class SalaireListVm
{
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
    public CompteDto CompteDebite { get; set; } = default!;
}
