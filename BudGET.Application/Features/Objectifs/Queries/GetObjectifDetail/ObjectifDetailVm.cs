namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail
{
    public class ObjectifDetailVm
    {
        public Guid Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Valeur { get; set; }
    }
}

