using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class logica
    {
        public static void ex1000()
        {
            Console.Write("Hello World!");

        }
        public static void ex1001()
        {
           int a = Convert.ToInt32(Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());
            int x = a + b;

            Console.WriteLine("X = " +x);
        }
        public static void ex1002()
        {
            double pi= 3.14159;
            

            double raio = Convert.ToDouble(Console.ReadLine());

                double a = pi * (raio * raio);

                Console.WriteLine("A="+a.ToString("0.0000"));
        }
        public static void ex1003()
        {
           int a = Convert.ToInt32(Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("SOMA = " + soma);


        }
        public static void ex1004()
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int prod = valor1 * valor2;

            Console.WriteLine("PROD = " + prod);
        }
        public static void ex1005()
        {
        const double a = 3.5;
        const double b = 7.5;

          double  nota1 = Convert.ToDouble(Console.ReadLine());
          double  nota2 = Convert.ToDouble(Console.ReadLine());

          double media = (nota1 * a + nota2 * b) / (a +b);
  
           Console.WriteLine("MEDIA = " + media.ToString("0.00000"));
        }
        public static void ex1006()
        {
            const double a = 2;
            const double b = 3;
            const double c = 5;

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * a + nota2 * b + nota3 * c) / (a + b + c);

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
        }

        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("\n\t| 0 para sair |\nDigite o programa desejado:");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.Write("--------------------\n");
                if (escolha == 0)
                {
                    Console.WriteLine("Obrigado por utilizar nosso programa");
                    break;
                }
                switch (escolha)
                {
                    case 0:
                        logica.ex1000();
                        break;
                    case 1:
                        logica.ex1001();
                        break;
                    case 2:
                        logica.ex1002();
                        break;
                    case 3:
                        logica.ex1003();
                        break;
                    case 4:
                        logica.ex1004();
                        break;
                    case 5:
                        logica.ex1005();
                        break;
                    case 6:
                        logica.ex1006();
                        break;

                    default:
                        Console.Write("Opção Invalida");
                        break;
                }



            } while (escolha != 0);



        }
    }
}

