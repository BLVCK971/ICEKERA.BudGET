using MediatR;

namespace BudGET.Application.Features.Depenses.Commands.DeleteDepense
{
    public class DeleteDepenseCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

