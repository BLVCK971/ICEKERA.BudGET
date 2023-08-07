namespace BudGET.Application.Features.Salaires.Queries.GetSalaireDetail;

public class SalaireDetailVm
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
    public CompteDto CompteDebite { get; set; } = default!;
}

