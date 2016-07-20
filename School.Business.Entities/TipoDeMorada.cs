using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TipoDeMorada : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int TipoDeMoradaId { get; set; }

        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public List<BusinessEntityMorada> BusinessEntityMorada { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TipoDeMoradaId;
            }
            set { TipoDeMoradaId = value; }
        }

        #endregion
    }
}