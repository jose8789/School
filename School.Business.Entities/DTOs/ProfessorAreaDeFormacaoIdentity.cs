namespace School.Data.Contracts.DTOs
{
    public class ProfessorAreaDeFormacaoIdentity
    {
        public int ProfessorId { get; set; }
        public int AreaDeFormacaoId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as ProfessorAreaDeFormacaoIdentity);
            return tmp?.ProfessorId == ProfessorId && tmp?.AreaDeFormacaoId == AreaDeFormacaoId;
        }
    }
}
