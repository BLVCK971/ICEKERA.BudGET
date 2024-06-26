﻿using BudGET.Domain.Common;

namespace BudGET.Domain.Entities;

public class Salaire : AuditableEntity
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
    public Guid CompteId { get; set; }
    public Compte CompteDebite { get; set; } = default!;
}

