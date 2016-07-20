using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class BusinessEntityAluno : EntityBase, IIdentifiableEntity<int>
    {
        [DataMember]
        public int BusinessEntityId { get; set; }

        [DataMember]
        public List<BusinessEntityMorada> BusinessEntityMorada { get; set; }

        [DataMember]
        public Funcionario Funcionario { get; set; }
        [DataMember]
        public AlunoDadosPessoais AlunoDadosPessoais { get; set; }

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return BusinessEntityId; }
            set { BusinessEntityId = value; }
        }
        #endregion
    }
}