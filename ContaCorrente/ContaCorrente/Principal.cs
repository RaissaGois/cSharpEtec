using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente
{
    class Principal
    {
        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente();

            cc1.nome = "Raissa Victoria";
            cc1.cpf = "123.456.789-00";

            cc1.depositar(1000);
            cc1.sacar(500);
            cc1.verSaldo();

        }
    }
}
