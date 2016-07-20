using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TipoDeAvaliacao : EntityBase, IIdentifiableEntity<int>
    {
        public TipoDeAvaliacao()
        {
            Avaliacao = new List<Avaliacao>();
        }

        [DataMember]
        public int TipoDeAvaliacaoId { get; set; }

        [DataMember]
        public string Tipo { get; set; }

        [DataMember]
        public string Abreviacao { get; set; }

        [DataMember]
        public List<Avaliacao> Avaliacao { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TipoDeAvaliacaoId;
            }
            set { TipoDeAvaliacaoId = value; }
        }

        #endregion
    }
}