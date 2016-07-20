using System;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Bilhete : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int BusinessEntityId { get; set; }

        [DataMember]
        public string NumeroDeBilhete { get; set; }

        [DataMember]
        public DateTime DataDeEmissao { get; set; }

        [DataMember]
        public DateTime DataDeExpiracao { get; set; }

        [DataMember]
        public Pessoa Pessoa { get; set; }

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return BusinessEntityId; }
            set { BusinessEntityId = value; }
        }
        #endregion
    }
}