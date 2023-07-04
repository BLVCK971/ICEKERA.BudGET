using BudGET.Domain.Common;
using System;

namespace BudGET.Domain.Entities;

public class Budget : AuditableEntity
{
    public Guid Id { get; set; }
    public string Nom { get; set; }
    public double Montant { get; set; }
    public bool Exception { get; set; }

    public Budget() 
    {
        Nom = "";
        Montant = 0.0;
        Exception = false;
    }
}

