namespace School.Data.Contracts.DTOs
{
    public class AlunoProfissaoIdentity
    {
        public string AlunoId { get; set; }
        public int ProfissaoId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as AlunoProfissaoIdentity);
            return tmp?.AlunoId == AlunoId && tmp?.ProfissaoId == ProfissaoId;
        }
    }
}
