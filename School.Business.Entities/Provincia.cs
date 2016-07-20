using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Provincia : EntityBase, IIdentifiableEntity<int>
    {
        public Provincia()
        {
            Comunas = new List<Comuna>();
            Pessoas = new List<Pessoa>();
        }
        [DataMember]
        public int ProvinciaId { get; set; }

        [DataMember]
        public int PaisId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public Pais Pais { get; set; }
        [DataMember]
        public List<Comuna> Comunas { get; set; }

        [DataMember]
        public List<Pessoa> Pessoas { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return ProvinciaId;
            }
            set { ProvinciaId = value; }
        }

        #endregion
    }
}