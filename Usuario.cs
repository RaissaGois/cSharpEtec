using System;

namespace Usuario
{
    class Usuario
    {
        //atributos
        public string nome;
        public string email;
        public string login;
        public string senha;

        //método específico da classe
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo!");
        }
        //método principal
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá Mundo!");

            //método construtor
            //NomeDaClasse | nomeDaInstancia | = | comando new | método Construtor()
            Usuario u1 = new Usuario();

            //invocar o método provarExistencia()
            //nomeDaInstacia.nomeDoMetodo();
            u1.provarExistencia();

            //inserindo dados no objeto (instância)
            u1.nome = "Raíssa Victoria";
            u1.email = "raissa@etec.com";
            u1.login = "raissa";
            u1.senha = "13579";

            //exibindo os dados do objeto
            Console.WriteLine(u1.nome);
            Console.WriteLine(u1.email);
            Console.WriteLine(u1.login);
            Console.WriteLine(u1.senha);
        }
    }
}
