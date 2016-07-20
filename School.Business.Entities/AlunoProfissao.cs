using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class AlunoProfissao : EntityBase, IIdentifiableEntity<AlunoProfissaoIdentity>, IAlunoOwnedEntity
    {
        [DataMember]
        public string CodigoAluno { get; set; }
        [DataMember]
        public int ProfissaoId { get; set; }
        [DataMember]
        public Profissao Profissao { get; set; }
        [DataMember]
        public Aluno Aluno { get; set; }
        [DataMember]
        public AlunoProfissaoIdentity AlunoProfissaoIdentity { get; set; }
        public string AlunoOwnerId => CodigoAluno;
        
        
        #region IIdentifiable Member
        public AlunoProfissaoIdentity EntityId
        {
            get { return AlunoProfissaoIdentity ?? new AlunoProfissaoIdentity() {AlunoId = CodigoAluno, ProfissaoId = ProfissaoId}; }
            set { AlunoProfissaoIdentity = value; }
        }
        #endregion

        
    }
}