using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Turma : EntityBase, IIdentifiableEntity<int>
    {
        public Turma()
        {
            ProfessorTurma = new List<ProfessorTurma>();
            TurmaInfo = new List<TurmaInfo>();
        }
        [DataMember]
        public int TurmaId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public List<ProfessorTurma> ProfessorTurma { get; set; }

        [DataMember]
        public List<TurmaInfo> TurmaInfo { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TurmaId;
            }
            set { TurmaId = value; }
        }

        #endregion
    }
}