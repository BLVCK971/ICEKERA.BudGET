namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif;

public class CreateObjectifDto
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Valeur { get; set; }
}

