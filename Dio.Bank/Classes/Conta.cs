using System;
using Dio.Bank.Enum;

namespace Dio.Bank.Classes
{
    public class Conta
    {
        public TipoConta TipoConta { get; private set; }
        public double Saldo { get; private set; }
        public double Credito { get; private set; }
        public string Nome { get; private set; }

        public Conta()
        {
        }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Saque(double valor)
        {
            if (this.Saldo - valor < (this.Credito * -1))
            {
                Console.Write("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= valor;
            Console.Write($"Saque realizado com sucesso, Conta: {this.Nome}, Saldo:{this.Saldo}");
            return true;
        }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
            Console.Write($"Deposito realizado com sucesso, Conta: {this.Nome}, Saldo:{this.Saldo}");
        }

        public void Transferir(double valor, Conta contaDestino)
        {
            if (this.Saque(valor))
            {
                contaDestino.Deposito(valor);
            }
        }

        public override string ToString()
        {
            return "Titular da Conta " + this.Nome + " | "
            + " Saldo da Conta " + this.Saldo + " | "
            + "Credito da Conta " + this.Credito + " | "
            + "Tipo de Conta " + this.TipoConta;
        }
    }
}
