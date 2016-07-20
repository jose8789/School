using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    //This classe is equal to Funcionario, just split up 
    //for sake of avoiding cyclic relation between table 
    //Professor and Avaliacao
    [DataContract]
    public class AlunoDadosPessoais : EntityBase, IIdentifiableEntity<int>, IPessoaOwnedEntity
    {
        [DataMember]
        public int AlunoDadosPessoaisId { get; set; }

        [DataMember]
        public string PrimeiroNome { get; set; }

        [DataMember]
        public string NomeMedio { get; set; }

        [DataMember]
        public string UltimoNome { get; set; }

        [DataMember]
        public Aluno Aluno { get; set; }

        [DataMember]
        public string NumeroDeBilhete { get; set; }

        [DataMember]
        public DateTime DataDeEmissao { get; set; }

        [DataMember]
        public DateTime DataDeExpiracao { get; set; }

        [DataMember]
        public BusinessEntity BusinessEntity { get; set; }

        //[DataMember]
        //public List<EnderecoEletronico> EnderecoEletronico { get; set; }

        [DataMember]
        public Password Password { get; set; }

        [DataMember]
        public EncarregadoDeEducacao EncarregadoDeEducacao { get; set; }

        [DataMember]
        public List<Telefone> Telefone { get; set; }

        [DataMember]
        public List<Observacao> Observacoes { get; set; }

        [DataMember]
        public Pais Pais { get; set; }

        [DataMember]
        public int PaisId { get; set; }

        [DataMember]
        public Provincia Provincia { get; set; }

        [DataMember]
        public int ProvinciaId { get; set; }

        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string NomeCompleto => $"{PrimeiroNome}${NomeMedio}${UltimoNome}";

        #region IIdentifiable Member

        public int EntityId
        {
            get { return AlunoDadosPessoaisId; }
            set { AlunoDadosPessoaisId = value; }
        }

        #endregion

        public int PessoaOwnerId => AlunoDadosPessoaisId;
    }
}