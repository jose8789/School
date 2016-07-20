using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class NivelAcademico : EntityBase, IIdentifiableEntity<int>
    {
        public NivelAcademico()
        {
            Professor = new List<Professor>();
        }
        [DataMember]
        public int NivelAcademicoId { get; set; }

        [DataMember]
        public string Designacao { get; set; }

        [DataMember]
        public List<Professor> Professor { get; set; }

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return NivelAcademicoId;
            }
            set { NivelAcademicoId = value; }
        }

        #endregion
    }
}