using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class CursoInfo : EntityBase, IIdentifiableEntity<int>, IDiretorOwnedEntity
    {
        [DataMember]
        public int CursoInfoId { get; set; }

        [DataMember]
        public int? AnoLetivo { get; set; }

        [DataMember]
        public int? ProfessorId { get; set; }

        [DataMember]
        public int? CursoId { get; set; }

        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public Curso Curso { get; set; }

        [DataMember]
        public Professor Professor { get; set; }

        [DataMember]
        public Turno Turno { get; set; }

        public int DiretorOwnerId => ProfessorId ?? 0;

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get { return CursoInfoId; }
            set { CursoInfoId = value; }
        }

        #endregion
    }
}