using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Queries.GetDepensesList;

public class CompteDto
{
    public Guid Id { get; set; }
    public string Intitule { get; set; } = string.Empty;
}
