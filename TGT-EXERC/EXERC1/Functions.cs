using System;
using System.Collections.Generic;
using System.Text;

namespace EXERC1
{
    class Functions
    {
        private int[] dFaturamento = { 2, 2, 3 };
        //o comparador se inicia no primeiro elemento do array



        public void CalcMaiorMenor()
        {
            int maior = dFaturamento[0];
            int menor = dFaturamento[0];

            foreach (var value in dFaturamento)
            {
                if (value > maior)
                {
                    maior = value;
                }
                if (value < menor)
                {
                    menor = value;
                }
            }
            Console.WriteLine($"O menor valor é:  {menor}");
            Console.WriteLine($"O maior valor é: {maior}");

        }
        public void calcMedia()
        {

            double media;
            int Soma = 0;
            int tamanho = dFaturamento.Length;
            //percorre todo o array para somar os valores.
            for (int i = 0; i < tamanho; i++)
            {
                Soma += dFaturamento[i];

            }

            media = Soma / (double)tamanho;
            Console.WriteLine($"A media é: {media.ToString("F")}");

        }
    }
}
