using MediatR;

namespace BudGET.Application.Features.Comptes.Commands.DeleteCompte
{
    public class DeleteCompteCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

