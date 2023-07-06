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

namespace BudGET.Application.Features.Depenses.Commands.UpdateDepense
{
    public class UpdateDepenseCommandHandler : IRequestHandler<UpdateDepenseCommand>
    {
          private readonly IAsyncRepository<Depense> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateDepenseCommandHandler(IMapper mapper, IAsyncRepository<Depense> serviceRepository)
        {
            _mapper = mapper;
            _eventRepository = serviceRepository;
        }

        public async Task<Unit> Handle(UpdateDepenseCommand request, CancellationToken cancellationToken)
        {

            var serviceToUpdate = await _eventRepository.GetByIdAsync(request.Id);

            if (serviceToUpdate == null)
            {
                throw new NotFoundException(nameof(Depense), request.Id);
            }

            var validator = new UpdateDepenseCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, serviceToUpdate, typeof(UpdateDepenseCommand), typeof(Depense));

            await _eventRepository.UpdateAsync(serviceToUpdate);

            return Unit.Value;
        }
    }
}

