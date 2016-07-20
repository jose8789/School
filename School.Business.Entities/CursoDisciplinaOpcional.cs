using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class CursoDisciplinaOpcional : EntityBase, IIdentifiableEntity<int>
    {
        public int CursoDisciplinaOpcionalId { get; set; }
        public int  AnoLetivo { get; set; } 
        public CursoDisciplina CursoDisciplina { get; set; }
        public int CursoId { get; set; }
        public int DisciplinaId { get; set; }   

        #region IIdentifiableEntity Member

        public int EntityId
        {
            get
            {
                return CursoDisciplinaOpcionalId;
            }
            set
            {
                CursoDisciplinaOpcionalId = value;
            }
        }

        #endregion


    }
}