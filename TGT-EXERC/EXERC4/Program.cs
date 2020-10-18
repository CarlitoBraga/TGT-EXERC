using System;
using System.Collections.Generic;

namespace EXERC5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> fibonacci = new List<long>();
            fibonacci.Add(0);
            fibonacci.Add(1);

            Console.WriteLine("Digite um valor entre 0 e 20365011074");
            //Lê o valor digitado(Optei por não validar a entrada)
            long number = long.Parse(Console.ReadLine());
            for (int i = 0; i < 50; i++)
            {
                long soma;
                soma = fibonacci[i] + fibonacci[i + 1];
                fibonacci.Add(soma);
            }

            //verifica se o número está contido na List.
            if (fibonacci.Contains(number))
            {
                Console.WriteLine($"O número {number} está contido na sequência ");

            }
            else
            {
                Console.WriteLine($"O número {number} não está contido na sequência");
            }
        }
    }
}
