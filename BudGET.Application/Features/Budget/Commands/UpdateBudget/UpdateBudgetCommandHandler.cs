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

namespace BudGET.Application.Features.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommandHandler : IRequestHandler<UpdateBudgetCommand>
    {
          private readonly IAsyncRepository<Budget> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateBudgetCommandHandler(IMapper mapper, IAsyncRepository<Budget> serviceRepository)
        {
            _mapper = mapper;
            _eventRepository = serviceRepository;
        }

        public async Task<Unit> Handle(UpdateBudgetCommand request, CancellationToken cancellationToken)
        {

            var serviceToUpdate = await _eventRepository.GetByIdAsync(request.BudgetId);

            if (serviceToUpdate == null)
            {
                throw new NotFoundException(nameof(Budget), request.BudgetId);
            }

            var validator = new UpdateBudgetCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, serviceToUpdate, typeof(UpdateBudgetCommand), typeof(Budget));

            await _eventRepository.UpdateAsync(serviceToUpdate);

            return Unit.Value;
        }
    }
}

