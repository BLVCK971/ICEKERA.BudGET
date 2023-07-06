using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetDetail
{
    public class BudgetDetailVm
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Montant { get; set; }
        public bool Exception { get; set; }
    }
}

