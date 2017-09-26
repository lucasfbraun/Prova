using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class TipoDeAssociacao
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Periodo { get; set; }

        public int Mensalidade { get; set; }
    }
}