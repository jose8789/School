using School.Business.Entities;

namespace School.Data.Contracts.DTOs
{
    public class PropinaAlunoInfo
    {
        public Aluno Aluno { get; set; }
        public Propina Propina { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
