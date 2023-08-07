using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Objectifs.Commands.DeleteObjectif
{
    public class DeleteObjectifCommandHandler : IRequestHandler<DeleteObjectifCommand>
    {
        private readonly IAsyncRepository<Objectif> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteObjectifCommandHandler(IMapper mapper, IAsyncRepository<Objectif> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(DeleteObjectifCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.Id);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Objectif), request.Id);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}

