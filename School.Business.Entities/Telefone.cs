using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Telefone : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int TelefoneId { set; get; }

        [DataMember]
        public int? BusinessEntityId { get; set; }

        [DataMember]
        public string NumeroDeTelefone { get; set; }

        [DataMember]
        public int TipoDeNumeroDeTelefoneId { get; set; }

        [DataMember]
        public Pessoa Pessoa { get; set; }

        [DataMember]
        public TipoDeNumeroDeTelefone TipoDeNumeroDeTelefone { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TelefoneId;
            }
            set { TelefoneId = value; }
        }

        #endregion
    }
}