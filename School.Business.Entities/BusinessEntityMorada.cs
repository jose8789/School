using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class BusinessEntityMorada : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int BusinessEntityId { get; set; }

        [DataMember]
        public int MoradaId { get; set; }

        [DataMember]
        public int TipoDeMoradaId { get; set; }


        [DataMember]
        public BusinessEntity BusinessEntity { get; set; }

        [DataMember]
        public Morada Morada { get; set; }

        [DataMember]
        public TipoDeMorada TipoDeMorada { get; set; }

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return MoradaId; }
            set { MoradaId = value; }
        }
        #endregion
    }
}