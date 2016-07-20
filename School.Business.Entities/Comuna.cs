using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Comuna : EntityBase, IIdentifiableEntity<int>
    {
        public Comuna()
        {
            Bairros = new List<Bairro>();
        }
        [DataMember]
        public int ComunaId { get; set; }
        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public int ProvinciaId { get; set; }
        [DataMember]
        public Provincia Provincia { get; set; }

        [DataMember]
        public List<Bairro> Bairros { get; set; }

        #region IIdentifiableEntity Member
        public int EntityId
        {
            get { return ComunaId; }
            set { ComunaId = value; }
        }
        #endregion
    }
}
