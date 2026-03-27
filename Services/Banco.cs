using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBancario.Models;

namespace SistemaBancario.Services
{
    public class Banco
    {
        private List<Conta> contas = new List<Conta>();

        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }

        public void CriarContaCorrente(int numero, Cliente cliente)
        {
            contas.Add(new ContaCorrente(numero, cliente));
        }

        public void CriarContaPoupanca(int numero, Cliente cliente)
        {
            contas.Add(new ContaPoupanca(numero,  cliente));
        }

        public void ListarContas()
        {
            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta: {conta.Numero} | Cliente: {conta.Titular.Nome} | Saldo: {conta.Saldo} ");

            }
        }

        public Conta BuscarConta(int numero)
        {
            return contas.Find(c => c.Numero == numero);
        }

        public void Transferir(int origem, int destino, double valor)
        {
            var contaOrigem = BuscarConta(origem);
            var contaDestino = BuscarConta(destino);

            if (contaOrigem != null && contaDestino != null)
            {
                if (contaOrigem.Sacar(valor))
                {
                    contaDestino.Depositar(valor);
                    Console.WriteLine("Transferencia Realizada!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
        }
    }
}
