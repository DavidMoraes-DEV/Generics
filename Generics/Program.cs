using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * GENERICS:
            - Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são:
                - Reuso
                - Type safety
                - Performance
            - Uso comum: Coleções

            * PROBLEMA EXEMPLO 01:
            - Deseja-se fazer um programa que leio um conjunto de N números inteiros (N de 1 a 10), e depois imprima esses números de forma organizada conforme exemplo. Em seguida, informar qual foi o primeiro valor informado.
            EXEMPLO:

            How many value? 3
            10
            8
            23
            [10, 8, 23]
            First: 10

            SOLUÇÃO EXEMPLO SEM UTILIZAR GENERICS:
            */

            PrintService printService = new PrintService(); 

            PrintService printService1 = new PrintService();

            Console.Write("How many value? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
