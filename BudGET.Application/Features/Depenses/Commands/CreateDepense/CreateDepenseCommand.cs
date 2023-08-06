using BudGET.Application.Features.Depenses.Queries.GetDepenseDetail;
using BudGET.Domain.Entities;
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
        public string Nom { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double Valeur { get; set; }
        public bool Prevu { get; set; } = false;

        public Guid BudgetId { get; set; }
        public BudgetDto Budget { get; set; } = default!;
        public Guid CompteId { get; set; }
        public CompteDto CompteCredite { get; set; } = default!;
    }
}

