using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Deficiencia : EntityBase, IIdentifiableEntity<int>
    {
        public Deficiencia()
        {
            AlunoDeficiencias = new List<AlunoDeficiencia>();
        }
        [DataMember]
        public int DeficienciaId { get; set; }
        [DataMember]
        public string Designacao { get; set; }
        [DataMember]
        public List<AlunoDeficiencia> AlunoDeficiencias { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return DeficienciaId;
            }
            set { DeficienciaId = value; }
        }

        #endregion
    }
}
