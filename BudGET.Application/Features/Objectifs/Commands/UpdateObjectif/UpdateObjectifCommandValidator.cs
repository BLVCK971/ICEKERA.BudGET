using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.UpdateObjectif
{
    public class UpdateObjectifCommandValidator : AbstractValidator<UpdateObjectifCommand>
    {
        public UpdateObjectifCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas exc�der 10 carat�res.");
        }
    }
}

