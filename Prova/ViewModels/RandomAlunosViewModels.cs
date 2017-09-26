using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prova.Models;

namespace Prova.ViewModels
{
    public class RandomAlunosViewModels
    {
        public Aluno Alunos { get; set; }
        public List<Faixa> Faixas { get; set; }
        public List<TipoDeAssociacao> Tipos { get; set; }
    }
}