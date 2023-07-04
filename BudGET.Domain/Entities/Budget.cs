using BudGET.Domain.Common;
using System;

namespace BudGET.Domain.Entities;

public class Budget : AuditableEntity
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Montant { get; set; } = double.MinValue;
    public bool Exception { get; set; } = false;

}

