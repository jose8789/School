 using System;
using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace School.Business.Entities
{
    [DataContract]
    public class Aluno : EntityBase, IIdentifiableEntity<int>, IAlunoOwnedEntity
    {
        public Aluno()
        {
            AlunoDeficiencia = new List<AlunoDeficiencia>();
            AlunoDisciplinasEmAtraso = new List<AlunoDisciplinaEmAtraso>();
            AlunoProfissoes = new List<AlunoProfissao>();
            AlunoTurmas = new List<AlunoTurma>();
            Propinas = new List<Propina>();
            Avaliacoes = new List<Avaliacao>();
            LivroDePontoDosAlunos = new List<LivroDePontoDoAluno>();
        }
        [DataMember]
        public int AlunoId { get; set; }
        [DataMember]
        public int AnoLetivo { get; set; }

        [DataMember]
        public int? CursoId { get; set; }

        [DataMember]
        public bool Ativo { get; set; }

        [DataMember]
        public byte[] Foto { get; set; }
        [DataMember]
        public string Codigo { get; set; }  
        [DataMember]
        public Pessoa Pessoa { get; set; }
        [DataMember]
        public DateTime DataDeNascimento { get; set; }
        [DataMember]
        public List<AlunoDisciplinaEmAtraso> AlunoDisciplinasEmAtraso { get; set; }

        [DataMember]
        public List<AlunoTurma> AlunoTurmas { get; set; }
        [DataMember]
        public List<Propina> Propinas { get; set; }

        [DataMember]
        public List<Avaliacao> Avaliacoes { get; set; }

        [DataMember]
        public Curso Curso { get; set; }
        [DataMember]
        public string ProcessoNumero { get; set; }
        [DataMember]
        public List<AlunoDeficiencia> AlunoDeficiencia { get; set; }

        public string AlunoOwnerId => Codigo;
        public List<AlunoProfissao> AlunoProfissoes { get; set; }

        public int EntityId
        {
            get {return AlunoId;}
            set { AlunoId = value; }
        }
        [DataMember]
        public List<LivroDePontoDoAluno> LivroDePontoDosAlunos { get; set; }

        [DataMember]
        public Escola Escola { get; set; }
        [DataMember]
        public int  EscolaId { get; set; }
        [DataMember]
        public int Classe { get; set; }
        [DataMember]
        [InverseProperty("EncarregadoPrincipalFor")]
        [ForeignKey("EncarregadoPrincipalId")]
        public EncarregadoDeEducacao EncarregadoPrincipal { get; set; }
        [DataMember]
        public int? EncarregadoPrincipalId { get; set; }
        [DataMember]
        [InverseProperty("EncarregadoSecundarioFor")]
        [ForeignKey("EncarregadoSecundarioId")]
        public EncarregadoDeEducacao EncarregadoSecundario { get; set; }
        [DataMember]
        public int? EncarregadoSecundarioId { get; set; } 

    }
}