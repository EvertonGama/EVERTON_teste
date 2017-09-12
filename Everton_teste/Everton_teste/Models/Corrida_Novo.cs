using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Everton_teste.Models
{
    public class Corrida_Novo
    {
        public Corrida_Novo()
        {
            Motoristas = new List<Corrida_Mototristas>();
            Passageiros = new List<Corrida_Passageiros>();
        }
        public List<Corrida_Mototristas> Motoristas { get; set; }
        public List<Corrida_Passageiros> Passageiros { get; set; }
    }

    public class Corrida_Novo_Salvar
    {
        public int Motorista { get; set; }
        public int Passageiro { get; set; }
        public string Valor { get; set; }
    }

    public class Corrida_Mototristas
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }

    public class Corrida_Passageiros
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}