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

            * SOLUÇÃO EXEMPLO COM GENERICS:
            */

            PrintService<string> printService = new PrintService<string>(); //Agora utilizando a classe parâmetrizada com um tipo genérico podemos escolher o tipo que precisamos usar nesse caso colocando seu tipo específico entre "<>" para informar qual será seu tipo nesse momento.

            PrintService<int> printService1 = new PrintService<int>(); //E para utilizar a mesma classe com um tipo específico diferente não é necessário criar uma nova classe com o tipo específico ou alterar nada na classe existente, apenas é necessário declarar o tipo desejado na frente do nome da classe quando for declara-la novamente.

            Console.Write("How many value? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            /*int a = (int)printService.First(); //Agora o Tipe Safity funciona e não deixa ocorrer aquele erro do object ao qual o compilador não consegue identificar a incompatibilidade antes de executar o código.
            int b = a + 2;
            Console.WriteLine(b);*/

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
