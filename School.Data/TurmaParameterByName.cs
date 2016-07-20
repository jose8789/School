using Core.Common.Contracts;

namespace School.Data
{
    public class TurmaParameterByName : ITurmaParameterByName
    {
        public string TurmaDesignacao { get; set; }
        public string CursoAbreviacao { get; set; }
        public string TurnoDesignacao { get; set; }
        public int AnoLetivo { get; set; }
        public int Classe { get; set; }
        public int Sala { get; set; }
    }
}