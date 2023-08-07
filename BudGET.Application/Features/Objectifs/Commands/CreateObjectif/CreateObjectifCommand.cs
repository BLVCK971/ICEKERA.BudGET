using MediatR;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommand : IRequest<CreateObjectifCommandResponse>
    {
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }
    }
}

