using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Pais : EntityBase, IIdentifiableEntity<int>
    {
        public Pais()
        {
            Provincia = new List<Provincia>();
            Pessoas = new List<Pessoa>();
        }
        [DataMember]
        public int PaisId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public List<Provincia> Provincia { get; set; }

        [DataMember]
        public List<Pessoa> Pessoas { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return PaisId;
            }
            set { PaisId = value; }
        }

        #endregion
    }
}