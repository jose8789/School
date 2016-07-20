using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class LivroDePontoDoProfessor : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int LivroDePontoDoProfessorId { get; set; } 
        [DataMember]   
        public LivroDePonto LivroDePonto { get; set; }
        [DataMember]
        public int LivroDePontoId { get; set; }
        [DataMember]
        public Professor Professor { get; set; }
        [DataMember]
        public int ProfessorId { get; set; }    
        [DataMember]
        public bool Presenca { get; set; }
        public int EntityId
        {
            get { return LivroDePontoDoProfessorId; }
            set { LivroDePontoDoProfessorId = value; }
        }
    }
}