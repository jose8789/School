namespace School.Data.Contracts.DTOs
{
    public class AlunoTurmaIdentity
    {
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as AlunoTurmaIdentity);
            return tmp?.AlunoId == AlunoId && tmp?.TurmaId == TurmaId;
        }
    }
}
