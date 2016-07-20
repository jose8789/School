using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Morada : EntityBase, IIdentifiableEntity<int>
    {
        public Morada()
        {
            BusinessEntityMorada = new List<BusinessEntityMorada>();
        }
        [DataMember]
        public int MoradaId { get; set; }

        [DataMember]
        public int? MoradaPrincipal { get; set; }
        [DataMember]
        [InverseProperty("MoradaPrincipal")]
        [ForeignKey("MoradaPrincipal")]
        public Bairro BairroPrincipal { get; set;    }

        [DataMember]
        public int? MoradaSecundaria { get; set; }
        [DataMember]
        [InverseProperty("MoradaSecundaria")]
        [ForeignKey("MoradaSecundaria")]
        public Bairro BairroSecundario { get; set; }

        [DataMember]
        public string Cidade { get; set; }

        [DataMember]
        public string CodigoPostal { get; set; }

        [DataMember]
        public List<BusinessEntityMorada> BusinessEntityMorada { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return MoradaId;
            }
            set { MoradaId = value; }
        }

        #endregion
    }
}