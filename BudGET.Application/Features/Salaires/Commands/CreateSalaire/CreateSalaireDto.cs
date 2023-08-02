using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire;

public class CreateSalaireDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
    public CompteDto CompteDebite { get; set; } = default!;
}

