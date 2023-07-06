using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.ObjectifId);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Objectif), request.ObjectifId);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}
