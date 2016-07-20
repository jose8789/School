using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class TipoDeFormacao : EntityBase, IIdentifiableEntity<int>
    {
        public TipoDeFormacao()
        {
            CursoDisciplinas = new List<CursoDisciplina>();
        }
        [DataMember]
        public int TipoDeFormacaoId { get; set; }
        [DataMember]
        public string  Designacao { get; set; }
        [DataMember]
        public List<CursoDisciplina> CursoDisciplinas { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return TipoDeFormacaoId;
            }
            set { TipoDeFormacaoId = value; }
        }

        #endregion
    }
}
