using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommand : IRequest<CreateObjectifCommandResponse>
    {
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }
    }
}

