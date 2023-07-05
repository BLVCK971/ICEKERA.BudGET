using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense
{
    public class CreateDepenseCommand : IRequest<CreateDepenseCommandResponse>
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double Valeur { get; set; }
    }
}

