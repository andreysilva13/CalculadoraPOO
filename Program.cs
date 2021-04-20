using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Calculadora calculadora = new Calculadora();

            while (true)
            {
                opcao = ObterOpcao();
                ObterOperacao(opcao, calculadora);

                if (OpcaoSair(opcao))
                {
                    break;
                }
                if (OpcaoInvalida(opcao))
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }
        }

        private static void ObterOperacao(string opcao, Calculadora calculadora)
        {
            switch (opcao)
            {
                case "1":                  
                    calculadora.Somar();
                    break;

                case "2":  
                    calculadora.Subtrair();
                    break;

                case "3":
                    calculadora.Multiplicar();
                    break;

                case "4":
                    calculadora.Dividir();
                    break;

                case "5":
                    Console.Clear();
                    calculadora.HistoricoOp();
                    break;

                default:
                    break;
            }
        }

        private static bool OpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        private static bool OpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5";
        }

        private static string ObterOpcao()
        {
            string opcao;
            Console.WriteLine("Digite qual operação você irá fazer"); Console.WriteLine("(1) SOMA"); Console.WriteLine("(2) SUBTRAÇÃO"); Console.WriteLine("(3) MULTIPLICAÇÃO"); Console.WriteLine("(4) DIVISÃO"); Console.WriteLine("(5) VISUALIZAR");

            opcao = Console.ReadLine();
            return opcao;
        }
    }
}