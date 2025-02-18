using System;

namespace Calculadora
{
    class Calculadora
    {
        public double n1;
        public double n2;

        public void somar()
        {
            Console.WriteLine("A soma é: ");
            Console.WriteLine(n1 + n2);

        }
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();

            c1.n1 = 3;
            c1.n2 = 2;
            c1.somar();
        }
    }
}
