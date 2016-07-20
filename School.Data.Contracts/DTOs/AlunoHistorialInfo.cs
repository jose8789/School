using School.Business.Entities;

namespace School.Data.Contracts.DTOs
{
    public class AlunoHistorialInfo
    {
        public Aluno Aluno { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public LivroDePontoDoAluno LivroDePontoDoAluno { get; set; }
    }
}
