using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prova.Models
{   
    [Table("dbo.Alunos")]
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public Faixa faixa { get; set; }
        public TipoDeAssociacao tipoAssociacao { get; set; }
    }
}