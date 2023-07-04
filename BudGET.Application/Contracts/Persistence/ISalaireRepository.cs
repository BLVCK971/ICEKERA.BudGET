using BudGET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Contracts.Persistence
{
    public interface ISalaireRepository : IAsyncRepository<Salaire>
    {
    }
}
