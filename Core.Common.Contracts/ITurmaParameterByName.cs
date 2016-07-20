namespace Core.Common.Contracts
{
    public interface ITurmaParameterByName : IRepositoryLongParameter
    {
        string TurmaDesignacao { get; set; }
        string CursoAbreviacao { get; set; }
        string TurnoDesignacao { get; set; }
        int AnoLetivo { get; set; }
        int Classe { get; set; }
        int Sala { get; set; }
    }
}