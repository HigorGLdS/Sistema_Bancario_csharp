using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, Cliente titular)
            : base(numero, titular)
        {

        }

        public void RenderJuros()
        {
            saldo += saldo * 0.2;
        }
    }
}
