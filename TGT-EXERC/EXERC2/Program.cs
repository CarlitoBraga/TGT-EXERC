using System;

namespace EXERC2
{

    class Program
    {
        class Soma : ISomaMult
        {
            public int CalcSomaMult(int value1, int value2)
            {
                int result = value1 + value2;
                return result;

            }

        }

        class Mult : ISomaMult
        {
            public int CalcSomaMult(int value1, int value2)
            {
                int result = value1 * value2;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
