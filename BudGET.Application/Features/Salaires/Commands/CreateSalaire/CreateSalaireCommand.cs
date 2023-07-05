using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommand : IRequest<CreateSalaireCommandResponse>
    {
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }= double.MinValue;
    }
}

