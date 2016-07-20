namespace School.Data.Contracts.DTOs
{
    public class CursoDisciplinaIdentity
    {
        public int DisciplinaId { get; set; }
        public int CursoId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as CursoDisciplinaIdentity);
            return tmp?.CursoId == CursoId && tmp?.DisciplinaId == DisciplinaId;
        }
    }
}
