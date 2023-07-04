using BudGET.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudGET.Domain.Entities;

public class Depense : AuditableEntity
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public DateTime Date { get; set; }
    public double Valeur { get; set; }
    public Budget Categorie { get; set; }
}

