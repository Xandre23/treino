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
        public static void ex1007()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

                int diff = a * b - c * d;

                    Console.WriteLine("DIFERENCA = "+ diff);
        }
        public static void ex1008()
        {
            Console.WriteLine("************* Informações do funcionario ****************");
            int numero = Convert.ToInt32(Console.ReadLine());
            double horastrab = Convert.ToDouble(Console.ReadLine());
            double valor = Convert.ToDouble(Console.ReadLine());

            double salario = horastrab * valor;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("0.00"));
        }
        public static void ex1009()
        {
            string nome = Convert.ToString(Console.ReadLine());
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas efetuadas no mês em dinheiro");
                double vendas = Convert.ToDouble(Console.ReadLine());

            double comissao = salario + vendas * 0.15;


            Console.WriteLine("TOTAL = R$ " + comissao.ToString("0.00"));


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
                    case 7:
                        logica.ex1007();
                        break;
                    case 8:
                        logica.ex1008();
                        break;
                    case 9:
                        logica.ex1009();
                        break;

                    default:
                        Console.Write("Opção Invalida");
                        break;
                }



            } while (escolha != 0);



        }
    }
}

