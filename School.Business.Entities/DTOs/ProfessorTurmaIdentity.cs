namespace School.Data.Contracts.DTOs
{
    public class ProfessorTurmaIdentity
    {
        public int ProfessorId { get; set; }
        public int TurmaId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as ProfessorTurmaIdentity);
            return tmp?.ProfessorId == ProfessorId && tmp?.TurmaId == TurmaId;
        }
    }
}
