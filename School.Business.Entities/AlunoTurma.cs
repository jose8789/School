using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class AlunoTurma : EntityBase, IIdentifiableEntity <AlunoTurmaIdentity>, IAlunoOwnedEntity
    {
        [DataMember]
        public int AlunoTurmaId { get; set; }
        [DataMember]
        public string CodigoAluno { get; set; }

        [DataMember]
        public int? NumeroDoAluno { get; set; }

        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]
        public TurmaInfo TurmaInfo { get; set; }

        public string AlunoOwnerId => CodigoAluno;

        #region IIdentifiableEntity Member
        public AlunoTurmaIdentity EntityId { get; set; }
        #endregion

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
        public int Classe { get; set; }
        [DataMember]
        public int AnoLetivo { get; set; }
        #endregion
    }
}