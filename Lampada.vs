using System;

namespace Lampada
{
    class Lampada
    {
        public int lampadaNro;
        public string comodo;
        public bool status;

        public void provarExistencia()
        {
            Console.WriteLine("Oi Lâmpada");
        }
        static void Main(string[] args)

        {
            // Console.WriteLine("Olá Mundo!");
            Lampada l1 = new Lampada();

            l1.provarExistencia();

            l1.lampadaNro = 1;
            l1.comodo = "quarto";
            l1.status = true;

            Console.WriteLine(l1.lampadaNro);
            Console.WriteLine(l1.comodo);
            Console.WriteLine(l1.status);

            Lampada l2 = new Lampada();

            l2.provarExistencia();

            l2.lampadaNro = 2;
            l2.comodo = "sala de jantar";
            l2.status = false;

            Console.WriteLine(l2.lampadaNro);
            Console.WriteLine(l2.comodo);
            Console.WriteLine(l2.status);

        }
    }
}
