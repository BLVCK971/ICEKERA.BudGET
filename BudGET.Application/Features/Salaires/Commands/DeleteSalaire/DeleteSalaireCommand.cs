using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.DeleteSalaire
{
    public class DeleteSalaireCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

