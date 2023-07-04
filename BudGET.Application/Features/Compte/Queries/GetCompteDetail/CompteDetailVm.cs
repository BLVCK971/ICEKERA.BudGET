using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Queries.GetCompteDetail
{
    public class CompteDetailVm
    {
        public Guid CompteId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public string RoleId { get; set; }
    }
}

