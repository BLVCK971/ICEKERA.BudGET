using MediatR;

namespace BudGET.Application.Features.Objectifs.Commands.DeleteObjectif
{
    public class DeleteObjectifCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

