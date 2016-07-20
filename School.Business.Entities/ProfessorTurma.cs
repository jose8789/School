using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class ProfessorTurma : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int ProfessorTurmaId { get; set; }

        [DataMember]
        public int ProfessorId { get; set; }

        [DataMember]
        public int? DisciplinaId { get; set; }    

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        public Professor Professor { get; set; }
        public int FuncionarioOwnerId => ProfessorId;

        #region TurmaInfo elements

        [DataMember]
        public int TurnoId { get; set; }

        [DataMember]
        public int Sala { get; set; }

        [DataMember]
        public int TurmaId { get; set; }
        [DataMember]
        public int CursoId { get; set; }
        [DataMember]
        public int? Classe { get; set; }
        [DataMember]
        public int AnoLetivo { get; set; }
        #endregion

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return ProfessorTurmaId;
            }
            set
            {
                ProfessorTurmaId = value;
            }
        }

        #endregion

    }
}