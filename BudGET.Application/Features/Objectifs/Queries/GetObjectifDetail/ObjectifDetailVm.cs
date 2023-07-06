using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail
{
    public class ObjectifDetailVm
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }
    }
}

