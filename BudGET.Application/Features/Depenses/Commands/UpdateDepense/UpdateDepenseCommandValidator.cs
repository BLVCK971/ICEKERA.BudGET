using FluentValidation;

namespace BudGET.Application.Features.Depenses.Commands.UpdateDepense
{
    public class UpdateDepenseCommandValidator : AbstractValidator<UpdateDepenseCommand>
    {
        public UpdateDepenseCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas excéder 10 caratères.");
        }
    }
}

