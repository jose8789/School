using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class AlunoDeficiencia : EntityBase, IIdentifiableEntity<AlunoDeficienciaIdentity>, IAlunoOwnedEntity
    {
        [DataMember]
        public string CodigoAluno { get; set; }
        [DataMember]
        public int DeficienciaId { get; set; }
        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]
        public Deficiencia Deficiencia { get; set; }

        [DataMember]
        public AlunoDeficienciaIdentity AlunoDeficienciaIdentity { get; set; }
        public string AlunoOwnerId => CodigoAluno;

        #region IIdentifiable Member

        public AlunoDeficienciaIdentity EntityId{
            get { return AlunoDeficienciaIdentity ?? new AlunoDeficienciaIdentity() {AlunoId = CodigoAluno, DeficienciaId = DeficienciaId}; }
            set { AlunoDeficienciaIdentity = value; }
        }

        #endregion
    }
}
