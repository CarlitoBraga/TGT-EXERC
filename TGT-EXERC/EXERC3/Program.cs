using System;
using System.Collections.Generic;

namespace EXERC3
{
    class Program
    {
        static void Main(string[] args)
        {
            void calcSoma()
            {
                int soma = 0;
                var start = 100;
                int[] vetImpar;
                List<int> vetImpares = new List<int>();

                //PREENCHENDO O ARRAY COM OS NÚMEROS IMPARES
                for (var i = 0; i <= 100; i++)
                {
                    int elemento = start + i;

                    if ((elemento % 2) == 1)
                    {
                        vetImpares.Add(elemento);
                    }

                }

                int tamanho = vetImpares.Count;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += vetImpares[i];

                }

                Console.WriteLine("A soma dos números impares é: " + soma);
            }

            calcSoma();

        }
    }
}
