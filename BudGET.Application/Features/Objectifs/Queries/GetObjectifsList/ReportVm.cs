using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifsList
{
    public class ReportVm
    {
        public Guid ReportId { get; set; }
        public string? Name { get; set; }
    }
}
