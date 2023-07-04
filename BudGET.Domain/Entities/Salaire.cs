using BudGET.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudGET.Domain.Entities;

public class Salaire : AuditableEntity
{
    public string Nom { get; set; }
    public double Valeur { get; set; }
}

