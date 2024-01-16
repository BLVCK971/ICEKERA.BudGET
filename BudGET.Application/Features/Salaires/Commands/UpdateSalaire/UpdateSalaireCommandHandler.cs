using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.UpdateSalaire
{
    public class UpdateSalaireCommandHandler : IRequestHandler<UpdateSalaireCommand>
    {
        private readonly IAsyncRepository<Salaire> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateSalaireCommandHandler(IMapper mapper, IAsyncRepository<Salaire> serviceRepository)
        {
            _mapper = mapper;
            _eventRepository = serviceRepository;
        }

        public async Task Handle(UpdateSalaireCommand request, CancellationToken cancellationToken)
        {

            var serviceToUpdate = await _eventRepository.GetByIdAsync(request.Id);

            if (serviceToUpdate == null)
            {
                throw new NotFoundException(nameof(Salaire), request.Id);
            }

            var validator = new UpdateSalaireCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, serviceToUpdate, typeof(UpdateSalaireCommand), typeof(Salaire));

            await _eventRepository.UpdateAsync(serviceToUpdate);
        }
    }
}

