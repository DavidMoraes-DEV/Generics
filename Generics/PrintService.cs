using System;

namespace Generics
{
    class PrintService //Solução sem Generics
    {
        private int[] Values = new int[10]; 
        private int Count = 0;

        public void AddValue(int value)
        {
            if (Count == 10) //"Programação defensiva"
            {
                throw new InvalidOperationException("PrintService is full");
            }

            Values[Count] = value;
            Count++;
        }

        public int First() 
        {
            if (Count == 0) //"Programação defensiva"
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
