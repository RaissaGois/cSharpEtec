using System;

namespace ContaCorrente
{
    class ContaCorrente
    {
        public string nome;
        public string cpf;
        public double limiteCredito;
        public double saldo;
        public bool negativado;

        public double depositar(double valor)
        {
            saldo = saldo + valor;
            return saldo;
        }
        public double sacar(double valor)
        {
            saldo = saldo - valor;
            return saldo;
        }

        public void verSaldo()
        {
            Console.WriteLine("Titular: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Saldo: R$" + saldo);
        }
    }
}

