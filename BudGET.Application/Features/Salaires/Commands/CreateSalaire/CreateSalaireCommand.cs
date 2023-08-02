using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire;

public class CreateSalaireCommand : IRequest<CreateSalaireCommandResponse>
{
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; } = double.MinValue;
    public Guid CompteId { get; set; }
    public CompteDto CompteDebite { get; set; } = default!;
}

