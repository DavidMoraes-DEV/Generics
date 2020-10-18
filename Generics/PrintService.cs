using System;

namespace Generics
{
    class PrintService<T> //Essa solução com Generics faz a classe ficar parâmetrizado com o tipo "T", ou seja, um tipo genérico específico ao qual chamei de "T"
    {
        private T[] Values = new T[10]; //Aqui agora será do tipo "T" e não um tipo específico como antes(ver commit anteriores)
        private int Count = 0;

        public void AddValue(T value) //Aqui também será do tipo T
        {
            if (Count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            Values[Count] = value;
            Count++;
        }

        public T First() //Tipo T
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return Values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < Count - 1; i++)
            {
                Console.Write(Values[i] + ", ");
            }
            if (Count > 0)
            {
                Console.Write(Values[Count - 1]);
                Console.WriteLine("]");
            }
        }
    }
}
