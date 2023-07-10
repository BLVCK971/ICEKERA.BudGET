using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.DeleteObjectif
{
    public class DeleteObjectifCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

