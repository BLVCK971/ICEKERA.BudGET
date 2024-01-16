using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.DeleteSalaire
{
    public class DeleteSalaireCommandHandler : IRequestHandler<DeleteSalaireCommand>
    {
        private readonly IAsyncRepository<Salaire> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteSalaireCommandHandler(IMapper mapper, IAsyncRepository<Salaire> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task Handle(DeleteSalaireCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.Id);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Salaire), request.Id);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);
        }
    }
}

