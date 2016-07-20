using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class DisciplinaInfo : EntityBase, IIdentifiableEntity<int>, ICoordenadorOwnedEntity
    {
        [DataMember]
        public int DisciplinaInfoId { get; set; }

        [DataMember]
        public int AnoLetivo { get; set; }

        [DataMember]
        public int? ProfessorId { get; set; }

        [DataMember]
        public int DisciplinaId { get; set; }


        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        public Professor Professor { get; set; }

        public int CoordenadorOwnerId => ProfessorId ?? 0;

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return DisciplinaId;
            }
            set { DisciplinaId = value; }
        }

        #endregion
    }
}