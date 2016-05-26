using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static List<int> Numeros = new List<int>();

        static void Main(string[] args)
        {
            var maiorQuantidade = 0;
            var posicaoInicial = 1;

            for (int i = 1; i <= 1000; i++)
            {
                Numeros.Add(i);
                calcularProximoNumero(i);
                if (Numeros.Count() > maiorQuantidade)
                {
                    maiorQuantidade = Numeros.Count();
                    posicaoInicial = i;
                }

                Numeros = new List<int>();


            }

            Console.WriteLine(maiorQuantidade);

            Console.WriteLine(posicaoInicial);

        }

        private static void calcularProximoNumero(int numeroAtual)
        {
            if (numeroAtual == 1)
            {
                return;
            }

            Numeros.Add(numeroAtual);

            if (EhImpar(numeroAtual))
            {
                calcularProximoNumero((3 * numeroAtual) + 1);
            }
            else
            {
                calcularProximoNumero(numeroAtual / 2);
            }


        }

        private static bool EhImpar(int numeroAtual)
        {
            return numeroAtual % 2 != 0;
        }


    }
}
