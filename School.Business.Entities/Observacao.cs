using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Observacao : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int ObservacaoId { get; set; }
        [DataMember]
        public Pessoa Pessoa { get; set; }
        [DataMember]
        public int PessoaId { get; set; }
        [DataMember]
        public string Obs { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return ObservacaoId;
            }
            set { ObservacaoId = value; }
        }

        #endregion
    }
}
