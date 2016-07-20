using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Localizacao : EntityBase, IIdentifiableEntity<int>
    {
        public Localizacao()
        {
            TurmaInfo = new List<TurmaInfo>();
        }
        [DataMember]
        public int LocalizacaoId { get; set; }

        [DataMember]
        public string Local { get; set; }

        [DataMember]
        public List<TurmaInfo> TurmaInfo { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return LocalizacaoId;
            }
            set { LocalizacaoId = value; }
        }

        #endregion
    }
}