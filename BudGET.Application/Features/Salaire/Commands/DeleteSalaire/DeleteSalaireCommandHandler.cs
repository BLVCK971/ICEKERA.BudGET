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

        public async Task<Unit> Handle(DeleteSalaireCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.SalaireId);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Salaire), request.SalaireId);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}

