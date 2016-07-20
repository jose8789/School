using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Turno : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int TurnoId { get; set; }
        [DataMember]
        public string Designacao { get; set; }
        
        [DataMember]
        public List<CursoInfo> CursoInfo { get; set; }
        [DataMember]
        public List<ProfessorTurma> ProfessorTurma { get; set; }
        [DataMember]
        public List<TurmaInfo> TurmaInfo { get; set; }
        [DataMember]
        public List<TurnoInfo> TurnoInfo { get; set; }

        public Turno()
        {
            CursoInfo = new List<CursoInfo>();
            ProfessorTurma = new List<ProfessorTurma>();
            TurmaInfo = new List<TurmaInfo>();
            TurnoInfo = new List<TurnoInfo>();
        }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TurnoId;
            }
            set { TurnoId = value; }
        }

        #endregion
    }
}