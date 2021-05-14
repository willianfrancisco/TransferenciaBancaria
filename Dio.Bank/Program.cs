using System;
using System.Collections.Generic;
using Dio.Bank.Classes;
using Dio.Bank.Enum;

namespace Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string opcaoUsuario = menu.CriarMenu();


            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;

                    case "2":
                        InserirConta();
                        break;

                    case "3":
                        Transferir();
                        break;

                    case "4":
                        Sacar();
                        break;

                    case "5":
                        Depositar();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = menu.CriarMenu();
            }

        }

        private static void Transferir()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da conta de origem:");
            int ContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino:");
            int ContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido:");
            int valorDeposito = int.Parse(Console.ReadLine());

            listContas[ContaOrigem].Transferir(valorDeposito, listContas[ContaDestino]);
        }

        private static void Depositar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da conta:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado:");
            int valorDeposito = int.Parse(Console.ReadLine());

            listContas[indiceConta].Deposito(valorDeposito);
        }

        public static void Sacar()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da conta:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado:");
            int valorSaque = int.Parse(Console.ReadLine());

            listContas[indiceConta].Saque(valorSaque);
        }



        private static void ListarContas()
        {
            if (listContas.Count == 0)
            {
                Console.Write("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write($"#{i} ");
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.Write("Inserir Nova Conta!");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Conta Juridica:");
            int entradaTipoConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Nome do Titular da Conta:");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial da Conta:");
            double entradaSaldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o Credito da Conta:");
            double entradaCredito = Convert.ToDouble(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                                    saldo: entradaSaldo, credito: entradaCredito,
                                                    nome: entradaNome);

            listContas.Add(novaConta);
        }
    }
}
