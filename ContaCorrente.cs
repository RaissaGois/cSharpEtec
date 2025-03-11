using System;

namespace ContaCorrente
{
    class ContaCorrente
    {
        public string nome;
        public string cpf;
        public double LimiteCredito = 1000.00;
        public double saldo = 0.00;
        public bool negativado;

        public void depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Deposito de R$" + valor + " realizado com sucesso!");
        }

        public void sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque de R$" + valor + " realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void verSaldo()
        {
            Console.WriteLine("Titular: " + nome);
            Console.WriteLine("Saldo atual: R$" + saldo);
        }

        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();

            c1.nome = "Raissa Victoria";
            c1.cpf = "123.456.789-00";

            c1.depositar(500);
            c1.sacar(200);
            c1.verSaldo();
        }
    }
}