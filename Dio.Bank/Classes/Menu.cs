using System;

namespace Dio.Bank.Classes
{
    public class Menu
    {
        public string CriarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao BankSynk!");
            Console.WriteLine("Como Podemos Ajuda-lo ?");
            Console.WriteLine("Informe a opção Desejada!");
            Console.WriteLine();
            Console.WriteLine("1- Listar Contas:");
            Console.WriteLine("2- Inserir Nova Conta:");
            Console.WriteLine("3- Transferir:");
            Console.WriteLine("4- Sacar:");
            Console.WriteLine("5- Depositar:");
            Console.WriteLine("C- Limpar Tela:");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
