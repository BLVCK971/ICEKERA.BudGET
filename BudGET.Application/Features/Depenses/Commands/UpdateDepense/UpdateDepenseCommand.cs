using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Commands.UpdateDepense;

public class UpdateDepenseCommand : IRequest
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public bool Prevu { get; set; } = false;

    public Guid BudgetId { get; set; }
    public Guid CompteId { get; set; }
}

