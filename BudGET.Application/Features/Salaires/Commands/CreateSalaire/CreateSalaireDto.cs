using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire;

public class CreateSalaireDto
{
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
}

