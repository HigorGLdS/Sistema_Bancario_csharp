using System;
using SistemaBancario.Models;
using SistemaBancario.Services;

class Program
{
    static void Main()
    {
        Banco banco = new Banco();

        while (true)
        {
            Console.WriteLine("\n===== SISTEMA BANCARIO =====");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Transferir");
            Console.WriteLine("5 - Listar constas");
            Console.WriteLine("6 - Historico");
            Console.WriteLine("7 - Sair");

            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("CPF: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Numero da conta: ");
                    int numero = int.Parse(Console.ReadLine());

                    Cliente cliente = new Cliente(nome, cpf);
                    banco.CriarContaCorrente(numero, cliente);

                    Console.WriteLine("Conta Criada");
                    break;

                case "2":
                    Console.Write("Conta: ");
                    int contaDep = int.Parse(Console.ReadLine());

                    Console.Write("Valor: ");
                    double valorDep = double.Parse(Console.ReadLine());

                    var contaD = banco.BuscarConta(contaDep);
                    contaD?.Depositar(valorDep);

                    Console.WriteLine("Deposito realizado");
                    break;

                case "3":
                    Console.Write("Conta: ");
                    int contaSaq = int.Parse(Console.ReadLine());

                    Console.Write("Valor: ");
                    double valorSaq = double.Parse(Console.ReadLine());

                    var contaS = banco.BuscarConta(contaSaq);

                    if (contaS != null && contaS.Sacar(valorSaq))
                        Console.WriteLine("Saque realizado");
                    else
                        Console.WriteLine("Saldo insuficiente");

                        break;

                case "4":
                    Console.Write("Conta origem: ");
                    int origem = int.Parse(Console.ReadLine());

                    Console.Write("Conta destino: ");
                    int destino = int.Parse(Console.ReadLine());

                    Console.Write("Valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    banco.Transferir(origem, destino, valor);

                    break;

                case "5":
                    banco.ListarContas();
                    break;

                case "6":
                    Console.Write("Numero da Conta: ");
                    int contaHist = int.Parse(Console.ReadLine());

                    var contaH = banco.BuscarConta(contaHist);

                    if (contaH != null)
                    {
                        contaH.MostrarHistorico();
                    }

                    break;

                case "7":
                    Console.WriteLine("Encerrando sistema...");
                    return;

                default:

                    Console.WriteLine("Opcao Invalida");

                    break;

            }
        }
    }
}
