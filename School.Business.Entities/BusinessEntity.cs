using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class BusinessEntity : EntityBase, IIdentifiableEntity<int>
    {
        public BusinessEntity()
        {
            BusinessEntityMorada = new List<BusinessEntityMorada>();
        }
        [DataMember]
        public int BusinessEntityId { get; set; }

        [DataMember]
        public List<BusinessEntityMorada> BusinessEntityMorada { get; set; }

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