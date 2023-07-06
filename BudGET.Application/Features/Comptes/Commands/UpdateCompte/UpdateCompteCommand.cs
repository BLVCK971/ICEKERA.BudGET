using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.UpdateCompte
{
    public class UpdateCompteCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Intitule { get; set; } = string.Empty;
        public double Montant { get; set; } = double.MinValue;
        public bool EstCompteCourant { get; set; } = false;
    }
}

