using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class LivroDePontoDoAluno : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int LivroDePontoDoAlunoId { get; set; }
        public LivroDePonto LivroDePonto { get; set; }
        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]    
        public string CodigoAluno { get; set; }
        [DataMember]
        public bool Presenca { get; set; }
        public int EntityId
        {
            get { return LivroDePontoDoAlunoId; }
            set { LivroDePontoDoAlunoId = value; }
        }
    }
}