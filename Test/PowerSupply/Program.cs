using System;

namespace PowerSupply
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      Программа расчёта мощности БП
             *      для ПК в зависимости от комплектующих.
             *      Методы со ссылками и всевозможными параметрами
             */

            int Result = Calculation
                (x: int.Parse(Console.ReadLine()),
                 y: int.Parse(Console.ReadLine())
                 );

            Console.WriteLine(Result);
        }

        static int Calculation(int x, int y)
        {
            return x + y;
        }
    }
    }
}
