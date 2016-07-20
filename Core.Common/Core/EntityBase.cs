using System;
using System.Runtime.Serialization;

namespace Core.Common.Core
{
    [DataContract]
    public abstract class EntityBase : IExtensibleDataObject
    {
        #region IExtensibleDataObject Members

        public ExtensionDataObject ExtensionData { get; set; }

        #endregion

        #region  
        [DataMember]
        public Guid Rowguid { get; set; }

        [DataMember]
        public DateTime DataDeModificacao { get; set; }
        #endregion

    }
}
