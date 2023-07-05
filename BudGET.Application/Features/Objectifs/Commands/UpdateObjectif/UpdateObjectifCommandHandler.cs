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

namespace BudGET.Application.Features.Objectifs.Commands.UpdateObjectif
{
    public class UpdateObjectifCommandHandler : IRequestHandler<UpdateObjectifCommand>
    {
          private readonly IAsyncRepository<Objectif> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateObjectifCommandHandler(IMapper mapper, IAsyncRepository<Objectif> serviceRepository)
        {
            _mapper = mapper;
            _eventRepository = serviceRepository;
        }

        public async Task<Unit> Handle(UpdateObjectifCommand request, CancellationToken cancellationToken)
        {

            var serviceToUpdate = await _eventRepository.GetByIdAsync(request.ObjectifId);

            if (serviceToUpdate == null)
            {
                throw new NotFoundException(nameof(Objectif), request.ObjectifId);
            }

            var validator = new UpdateObjectifCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, serviceToUpdate, typeof(UpdateObjectifCommand), typeof(Objectif));

            await _eventRepository.UpdateAsync(serviceToUpdate);

            return Unit.Value;
        }
    }
}

