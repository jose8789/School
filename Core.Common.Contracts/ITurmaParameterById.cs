namespace Core.Common.Contracts
{
    public interface ITurmaParameterById : IRepositoryLongParameter
    {
        int TurmaId { get; set; }
        int CursoId { get; set; }
        int TurnoId { get; set; }
        int AnoLetivo { get; set; }
        int Classe { get; set; }
        int Sala { get; set; }
    }
}
