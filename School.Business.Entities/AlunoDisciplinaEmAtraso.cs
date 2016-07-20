using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class AlunoDisciplinaEmAtraso : EntityBase, IIdentifiableEntity<AlunoDisciplinaIdentity>, IAlunoOwnedEntity
    {
        [DataMember]
        public int DisciplinaId { get; set; }

        [DataMember]
        public string CodigoAluno { get; set; }

        [DataMember]
        public int Classe { get; set; }

        [DataMember]
        public int AnoLetivo { get; set; }

        [DataMember]
        public Aluno Aluno { get; set; }

        [DataMember]
        public Disciplina Disciplina { get; set; }
        [DataMember]
        public AlunoDisciplinaIdentity AlunoDeficienciaIdentity { get; set; }

        public string AlunoOwnerId => CodigoAluno;

        #region IIdentifiable Member
        public AlunoDisciplinaIdentity EntityId
        {
            get
            {
                return AlunoDeficienciaIdentity ?? new AlunoDisciplinaIdentity()
                {
                    AlunoId = CodigoAluno,
                    DisciplinaId = DisciplinaId
                };
            } 
            set { AlunoDeficienciaIdentity = value; }
        }
#endregion
        
    }
}