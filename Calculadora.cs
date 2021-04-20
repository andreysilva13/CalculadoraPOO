using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class Calculadora
    {
        public double Numero1;
        public double Numero2;
        public double Resultado;
        public string[] Historico = new string[30];
        public int contador = 0;
        public void Somar()
        {
            ObtemNumero();
            Resultado = Numero1 + Numero2;
            Historico[contador] = $"{Numero1} + {Numero2} = {Resultado}";
            Console.WriteLine(Historico[contador]);
            Console.ReadLine();
            Console.Clear();
            contador++;
        }

        private void ObtemNumero()
        {
            Console.Clear();
            Console.Write("Digite o primeiro número: "); Numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: "); Numero2 = System.Convert.ToDouble(Console.ReadLine());
        }

        public void Subtrair()
        {
            ObtemNumero();
            Resultado = Numero1 - Numero2;
            Historico[contador] = $"{Numero1} - {Numero2} = {Resultado}";
            Console.WriteLine(Historico[contador]);
            Console.ReadLine();
            Console.Clear();
            contador++;
        }

        public void Multiplicar()
        {
            ObtemNumero();
            Resultado = Numero1 * Numero2;
            Historico[contador] = $"{Numero1} * {Numero2} = {Resultado}";
            Console.WriteLine(Historico[contador]);
            Console.ReadLine();
            Console.Clear();
            contador++;
        }

        public void Dividir()
        {
            ObtemNumero();
            if (Numero2 != 0)
            {
                Resultado = Numero1 / Numero2;
                Historico[contador] = $"{Numero1} / {Numero2} = {Resultado}";
                Console.WriteLine(Historico[contador]);
                Console.ReadLine();
                Console.Clear();
                contador++;
            }
            else
            {
                Console.WriteLine("Não é possivel fazer essa operação.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void HistoricoOp()
        {
            for (int i = 0; i < contador; i++)
            {              
                System.Console.WriteLine(Historico[i]);
            }
            System.Console.ReadLine();
            System.Console.Clear();
        }
    }
}