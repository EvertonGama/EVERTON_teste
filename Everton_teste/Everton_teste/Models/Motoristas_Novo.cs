using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Everton_teste.Models
{
    public class Motoristas_Novo
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Modelo { get; set; }
        public int Status { get; set; }
        public string Sexo { get; set; }
    }
}