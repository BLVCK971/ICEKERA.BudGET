using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.UpdateSalaire;

public class UpdateSalaireCommand : IRequest
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
}

