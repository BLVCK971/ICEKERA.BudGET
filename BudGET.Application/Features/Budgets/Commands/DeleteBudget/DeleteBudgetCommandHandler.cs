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

namespace BudGET.Application.Features.Budgets.Commands.DeleteBudget
{
    public class DeleteBudgetCommandHandler : IRequestHandler<DeleteBudgetCommand>
    {
        private readonly IAsyncRepository<Budget> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteBudgetCommandHandler(IMapper mapper, IAsyncRepository<Budget> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(DeleteBudgetCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.Id);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Budget), request.Id);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}

