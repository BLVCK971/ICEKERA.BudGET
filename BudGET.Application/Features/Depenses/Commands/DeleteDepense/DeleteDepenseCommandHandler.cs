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

namespace BudGET.Application.Features.Depenses.Commands.DeleteDepense
{
    public class DeleteDepenseCommandHandler : IRequestHandler<DeleteDepenseCommand>
    {
        private readonly IAsyncRepository<Depense> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteDepenseCommandHandler(IMapper mapper, IAsyncRepository<Depense> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(DeleteDepenseCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.Id);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Depense), request.Id);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}

