using FluentValidation;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommandValidator : AbstractValidator<CreateObjectifCommand>
    {
        public CreateObjectifCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas exc�der 10 carat�res.");
        }
    }
}

