using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Profissao: EntityBase, IIdentifiableEntity<int>
    {
        public Profissao()
        {
            AlunoProfissoes = new List<AlunoProfissao>();
        }
        [DataMember]
        public int ProfissaoId { get; set; }
        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public List<AlunoProfissao> AlunoProfissoes { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return ProfissaoId;
            }
            set { ProfissaoId = value; }
        }

        #endregion
    }
}