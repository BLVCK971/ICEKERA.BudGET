using FluentValidation;

namespace BudGET.Application.Features.Salaires.Commands.UpdateSalaire
{
    public class UpdateSalaireCommandValidator : AbstractValidator<UpdateSalaireCommand>
    {
        public UpdateSalaireCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas excéder 10 caratères.");
        }
    }
}

