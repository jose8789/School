using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TipoDeNumeroDeTelefone : EntityBase, IIdentifiableEntity<int>
    {
        public TipoDeNumeroDeTelefone()
        {
            Telefone = new List<Telefone>();
        }
        [DataMember]
        public int TipoDeNumeroDeTelefoneId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public List<Telefone> Telefone { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TipoDeNumeroDeTelefoneId;
            }
            set { TipoDeNumeroDeTelefoneId = value; }
        }

        #endregion
    }
}