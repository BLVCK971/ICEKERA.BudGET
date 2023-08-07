using FluentValidation;

namespace BudGET.Application.Features.Objectifs.Commands.UpdateObjectif
{
    public class UpdateObjectifCommandValidator : AbstractValidator<UpdateObjectifCommand>
    {
        public UpdateObjectifCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas excéder 10 caratères.");
        }
    }
}

