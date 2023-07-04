using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Queries.GetDepenseDetail
{
    public class DepenseDetailVm
    {
        public Guid DepenseId { get; set; }
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public string RoleId { get; set; }
    }
}

