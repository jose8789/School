using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;
using School.Data.Contracts.DTOs;

namespace School.Business.Entities
{
    [DataContract]
    public class ProfessorAreaDeFormacao : EntityBase, IIdentifiableEntity<ProfessorAreaDeFormacaoIdentity>, IProfessorOwnedEntity
    {
        [DataMember]
        public int ProfessorId { get; set; }
        [DataMember]
        public int AreaDeFormacaoId { get; set; }
        [DataMember]
        public Professor Professor { get; set; }
        [DataMember]
        public AreaDeFormacao AreaDeFormacao { get; set; }

        public int FuncionarioOwnerId => ProfessorId;

        [DataMember]
        public ProfessorAreaDeFormacaoIdentity ProfessorAreaDeFormacaoIdentity { get; set; }

        #region IIdentifiableEntity Member

        public ProfessorAreaDeFormacaoIdentity EntityId
        {
            get
            {
                return ProfessorAreaDeFormacaoIdentity ??
                    new ProfessorAreaDeFormacaoIdentity() {ProfessorId = ProfessorId, AreaDeFormacaoId = AreaDeFormacaoId};
            }
            set { ProfessorAreaDeFormacaoIdentity = value; }
        }

        #endregion
    }
}