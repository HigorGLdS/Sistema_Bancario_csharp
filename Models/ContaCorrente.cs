using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
   public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, Cliente titular) : base(numero, titular)
        {

        }

        public override bool Sacar(double valor)
        {
            double taxa = 2;

            if (saldo >= valor + taxa)
            {
                saldo -= valor + taxa;
                return true;
            }

            return false;
        }
    }
}
