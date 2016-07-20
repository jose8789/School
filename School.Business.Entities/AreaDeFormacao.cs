using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class AreaDeFormacao : EntityBase, IIdentifiableEntity<int>
    {
        public AreaDeFormacao()
        {
            ProfessorAreasDeFormacao = new List<ProfessorAreaDeFormacao>();
        }
        [DataMember]
        public int AreaDeFormacaoId { get; set; }

        [DataMember]
        public string Designacao { get; set; }


        [DataMember]
        public List<ProfessorAreaDeFormacao> ProfessorAreasDeFormacao { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get { return AreaDeFormacaoId; }
            set { AreaDeFormacaoId = value; }
        } 
        #endregion
    }
}