using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Comptes.Commands.DeleteCompte
{
    public class DeleteCompteCommandHandler : IRequestHandler<DeleteCompteCommand>
    {
        private readonly IAsyncRepository<Compte> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteCompteCommandHandler(IMapper mapper, IAsyncRepository<Compte> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task Handle(DeleteCompteCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.Id);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Compte), request.Id);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);
        }
    }
}

