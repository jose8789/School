using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class EnderecoEletronico : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int BusinessEntityId { get; set; }

        [DataMember]
        public int EnderecoEletronicoId { get; set; }

        [DataMember]
        public string Email { get; set; }


        [DataMember]
        public Pessoa Pessoa { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return BusinessEntityId;
            }
            set { BusinessEntityId = value; }
        }

        #endregion
    }
}