using MediatR;

namespace BudGET.Application.Features.Objectifs.Commands.UpdateObjectif
{
    public class UpdateObjectifCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }
    }
}

