namespace School.Data.Contracts.DTOs
{
    public class AlunoDeficienciaIdentity
    {
        public string AlunoId { get; set; }
        public int DeficienciaId { get; set; }

        public override bool Equals(object obj)
        {
            var tmp = (obj as AlunoDeficienciaIdentity);
            return tmp?.AlunoId == AlunoId && tmp?.DeficienciaId == DeficienciaId;
        }
        
    }
}
