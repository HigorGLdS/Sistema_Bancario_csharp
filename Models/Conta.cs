using System;
using System.Collections.Generic;
using SistemaBancario.Transactions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }

        protected double saldo;

        protected List<Transacao> historico = new List<Transacao>();

        public double Saldo
        {
            get { return saldo; }
        }

        public Conta(int numero, Cliente titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            historico.Add(new Transacao("Deposito", valor));
        }

        public virtual bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                historico.Add(new Transacao("Saque", valor));
                return true;
            }

            return false;
        }

        public void MostrarHistorico()
        {
            foreach (var t in historico)
            {
                Console.WriteLine(t);
            }
        }

    }
}
