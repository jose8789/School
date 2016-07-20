using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Bairro : EntityBase, IIdentifiableEntity<int>
    {
        public Bairro()
        {
            MoradaPrincipal = new List<Morada>();
            MoradaSecundaria = new List<Morada>();
        }
        [DataMember]
        public int BairroId { get; set; }
        [DataMember]
        public string Designacao { get; set; }    
        [DataMember]
        public Comuna Comuna { get; set; }
        [DataMember]
        public int ComunaId { get; set; }
        [DataMember]
        public List<Morada> MoradaPrincipal { get; set; }
        [DataMember]
        public List<Morada> MoradaSecundaria { get; set; }  

        [DataMember]
        public int EntityId
        {
            get { return BairroId; }
            set { BairroId = value; }
        }

        
    }
}