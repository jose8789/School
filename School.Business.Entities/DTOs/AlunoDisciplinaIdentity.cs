namespace School.Data.Contracts.DTOs
{
    public class AlunoDisciplinaIdentity
    {
        public string AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as AlunoDisciplinaIdentity);
            return tmp?.AlunoId == AlunoId && tmp?.DisciplinaId == DisciplinaId;
        }
    }
}
