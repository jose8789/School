namespace School.Data.Contracts.DTOs
{
    public class LivroDePontoTurmaInfo<T,TE>
    {
        public T LivroDePonto { get; set; }
        public TE AlunoTurma { get; set; }
    }
}
