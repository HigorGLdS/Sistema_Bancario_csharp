using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Transactions
{
     public class Transacao
    {
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }

        public Transacao(string tipo, double valor)
        {
            Data = DateTime.Now;
            Tipo = tipo;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Data} | {Tipo} | R$ {Valor}";
        }
    }
}
