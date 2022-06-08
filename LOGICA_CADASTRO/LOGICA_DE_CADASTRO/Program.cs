using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGICA_CADASTRO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem-vindo ao SignalR");
            Cadastro();
        }
    
        public class Usuario
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public String Email { get; set; }
            public string Senha { get; set; }

        }
            public static void  Cadastro()
        {
             Usuario user = new Usuario();

            List<Usuario> cads = new List<Usuario>();

             Console.WriteLine("****************** cadastro *******************\n\n");
             Console.WriteLine("Digite seu nome:");
             user.Nome = Console.ReadLine();

             Console.WriteLine("Digite seu sobrenome:");
             user.Sobrenome = Console.ReadLine();

             Console.WriteLine("Digite seu email:");
             user.Email = Console.ReadLine();

             Console.WriteLine("Digite sua senha:");
             user.Senha = Console.ReadLine();

             cads.Add(user);

             Console.WriteLine("Cadastro realizado com sucesso");

            }
       
    }

}



    





