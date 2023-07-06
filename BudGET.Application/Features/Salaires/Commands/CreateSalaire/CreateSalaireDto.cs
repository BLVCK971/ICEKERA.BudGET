namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire;

public class CreateSalaireDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
}

