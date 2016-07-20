using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TurnoInfo : EntityBase, IIdentifiableEntity<int>, ICoordenadorOwnedEntity
    {
        [DataMember]
        public int TurnoInfoId { get; set; }

        [DataMember]
        public int? ProfessorId { get; set; }

        [DataMember]
        public int AnoLetivo { get; set; }

        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public Turno Turno { get; set; }

        [DataMember]
        public Professor Professor { get; set; }

        public int CoordenadorOwnerId => ProfessorId ?? 0;

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TurnoInfoId;
            }
            set { TurnoInfoId = value; }
        }

        #endregion
    }
}